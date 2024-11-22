using GemBox.Document;

ComponentInfo.SetLicense("FREE-LIMITED-KEY");

DocumentModel document = DocumentModel.Load("headerExample.docx");
document.Bookmarks["Bookmark1"].GetContent(false).LoadText("Bookmark1 replaced by this.");
document.Bookmarks["Bookmark2"].GetContent(false).LoadText("Bookmark2 replaced by this.");

document.Save("test.pdf");
