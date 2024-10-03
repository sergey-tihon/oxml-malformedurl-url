using DocumentFormat.OpenXml.Packaging;

using var fs = File.Open("repro.pptx", FileMode.Open, FileAccess.Read);
var openSettings = new OpenSettings { AutoSave = false };
using var doc = PresentationDocument.Open(fs, false, openSettings);

var presentation = doc.PresentationPart!.Presentation!;
var slideIds = presentation.SlideIdList?.ChildElements;
Console.WriteLine(slideIds?.Count ?? -1);
