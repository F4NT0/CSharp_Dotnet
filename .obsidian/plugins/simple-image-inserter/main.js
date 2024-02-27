/*
THIS IS A GENERATED/BUNDLED FILE BY ESBUILD
if you want to view the source, please visit the github repository of this plugin
*/

var __create = Object.create;
var __defProp = Object.defineProperty;
var __getOwnPropDesc = Object.getOwnPropertyDescriptor;
var __getOwnPropNames = Object.getOwnPropertyNames;
var __getProtoOf = Object.getPrototypeOf;
var __hasOwnProp = Object.prototype.hasOwnProperty;
var __export = (target, all) => {
  for (var name in all)
    __defProp(target, name, { get: all[name], enumerable: true });
};
var __copyProps = (to, from, except, desc) => {
  if (from && typeof from === "object" || typeof from === "function") {
    for (let key of __getOwnPropNames(from))
      if (!__hasOwnProp.call(to, key) && key !== except)
        __defProp(to, key, { get: () => from[key], enumerable: !(desc = __getOwnPropDesc(from, key)) || desc.enumerable });
  }
  return to;
};
var __toESM = (mod, isNodeMode, target) => (target = mod != null ? __create(__getProtoOf(mod)) : {}, __copyProps(
  // If the importer is in node compatibility mode or this is not an ESM
  // file that has been converted to a CommonJS file using a Babel-
  // compatible transform (i.e. "__esModule" has not been set), then set
  // "default" to the CommonJS "module.exports" for node compatibility.
  isNodeMode || !mod || !mod.__esModule ? __defProp(target, "default", { value: mod, enumerable: true }) : target,
  mod
));
var __toCommonJS = (mod) => __copyProps(__defProp({}, "__esModule", { value: true }), mod);

// main.ts
var main_exports = {};
__export(main_exports, {
  default: () => ImageInserter
});
module.exports = __toCommonJS(main_exports);
var import_obsidian2 = require("obsidian");

// src/file_modal.ts
var import_obsidian = require("obsidian");

// src/file_embedder.ts
var import_fs = __toESM(require("fs"));
var import_path = __toESM(require("path"));
var FileEmbedder = class {
  constructor(attachmentsFolder) {
    this.attachmentsFolder = attachmentsFolder;
  }
  embedLinkFor(filePath) {
    const filename = import_path.default.basename(filePath);
    return "![[" + filename + "]]\n";
  }
  copyFileToAttachmentsDir(filePath) {
    import_fs.default.mkdirSync(this.attachmentsFolder, { recursive: true });
    const fileName = import_path.default.basename(filePath);
    import_fs.default.copyFileSync(filePath, import_path.default.resolve(this.attachmentsFolder, fileName));
  }
};

// src/file_modal.ts
var import_path2 = __toESM(require("path"));
var FileModal = class extends import_obsidian.Modal {
  constructor(app) {
    super(app);
  }
  onOpen() {
    const { contentEl } = this;
    const input = contentEl.createEl("input", {
      type: "file",
      attr: { accept: "image/*", multiple: true }
    });
    input.addEventListener("cancel", () => {
      new import_obsidian.Notice("Canceled adding images");
      this.close();
    });
    input.addEventListener("change", () => {
      this.close();
      const attachmentsDest = this.getAttachmentsDestination();
      const fileEmbedder = new FileEmbedder(attachmentsDest);
      const fileList = Array.from(input.files || []);
      fileList.forEach((file) => {
        const filePath = file.path;
        fileEmbedder.copyFileToAttachmentsDir(filePath);
        const embedLinkToFile = fileEmbedder.embedLinkFor(filePath);
        this.addText(embedLinkToFile);
      });
      new import_obsidian.Notice(`Added ${fileList.length} images`);
    });
    input.click();
  }
  getAttachmentsDestination() {
    const attachementFolder = this.app.vault.config.attachmentFolderPath;
    let basePath = this.app.vault.adapter.basePath;
    if (attachementFolder.startsWith("./")) {
      basePath = import_path2.default.join(basePath, this.app.workspace.getActiveFile().parent.path);
    }
    return import_path2.default.join(basePath, attachementFolder);
  }
  addText(text) {
    const view = this.app.workspace.getActiveViewOfType(import_obsidian.MarkdownView);
    if (view) {
      view.editor.replaceSelection(text);
    }
  }
  onClose() {
    const { contentEl } = this;
    contentEl.empty();
  }
};

// main.ts
var ImageInserter = class extends import_obsidian2.Plugin {
  async onload() {
    this.addCommand({
      id: "image-insert",
      name: "Insert image(s)",
      callback: () => {
        new FileModal(this.app).open();
      }
    });
  }
};
