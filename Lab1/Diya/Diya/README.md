1) The first principle Single responsibility - example: [клас Container](./Container.cs).
   This class is responsible for working with a group of documents, its task is to output documents in a different forms.
2) Open-closed Principle. [class DriverLicense](./DriverLicenseAction.cs) and [class CopyAction](./CopyAction.cs).
   If we need to create a document with our special method (copy code or certificate validity)
   you just need to create a class that will implement [IDocumentAction interface](./IDocumentAction.cs), then it is transferred
    as an argument in [клас ActionDocument](./ActionDocument.cs) as this interface. In client code [create object](./Program.cs)
   then we just call method from [interface IActionUser](./IActionUser.cs)  to which we pass the object of the created class.
3) Interface segregation principle - for documents which haven`t action functions [interface IDocument](./IDocument.cs)
   for documents which have action functions: [use interface IDocumentAction](./IDocumentAction.cs).
4) Dependency inversion - in [Program.cs](./Program.cs) inside [Container.cs](./Container.cs) the objects of the created documents are transferred under a common interface [IDocument](./IDocument.cs).
5) DRY - classes are implemented in such a way that they do not duplicate each other's code. To implement classes that must perform certain actions ->  [ActionDocument](./ActionDocument.cs) base class object is used: [Document:IDocument](./Document.cs).
   This way we don't need to create nearly identical classes for both types of documents.
6) Composition Over Inheritance - to create [ActionDocument](./ActionDocument.cs) it use object of the class that implements the interface [IDocument](./IDocument.cs) rather than creating a base Document class and inheriting from it.
7) KISS - The created classes are simple, "short" and readable. The client code is not overloaded, the class is responsible for displaying information: [Container](./Container.cs).
8) YAGNI - redundant or additional functionality is not implemented). 