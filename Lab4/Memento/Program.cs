// See https://aka.ms/new-console-template for more information

using Memento;

TextEditor editor = new TextEditor("Some start content");
Console.WriteLine("Start content: " + editor.GetContent());

editor.SetContent("Content that I want to save");
Console.WriteLine("Modified content: " + editor.GetContent());
editor.Save();

editor.SetContent("Content that I want to cancel later");
Console.WriteLine("Modified content: " + editor.GetContent());

editor.Undo();
Console.WriteLine("After undo: " + editor.GetContent());
