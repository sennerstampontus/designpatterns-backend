# DESIGN PATTERN
* This project was created with SOLID in mind. 
* I've used the pattern of MVC . Model View Controller.
* Where in an API project is more or less just MC pattern.
* I'm not using the M[``V``]C in the same meaning when creating a MVC application, but have the same design pattern in mind when creating this .NET WebApi.
* [``M``]VC is my Models for creating a product or how a product should look like to match the database.
* MV[``C``] is my controllers to Create and Get a product or list of products. 

# SOLID Principles
* I've commented in respective files where I found that I should use one or more principles, considering SOLID.
* For convinience, I've put together a list down below, to make it easier to find and navigate.

    ___

    * [CreateShoeController - SRP, OCP, DIP](designpatterns_api/Controllers/ShoeControllers/CreateShoeController.cs)
    * [GetShoeController - SRP, OCP, DIP](designpatterns_api/Controllers/ShoeControllers/GetShoeController.cs)
    * [CreateWatchController - SRP, OCP, DIP](designpatterns_api/Controllers/WatchControllers/CreateWatchController.cs)
    * [GetWatchController - SRP, OCP, DIP](designpatterns_api/Controllers/WatchControllers/GetWatchController.cs)
    * [GenericFactory - SRP, DRY](designpatterns_api/Factories/GenericFactory.cs)
    * [ShoeFactory - DIP, ("SRP")](designpatterns_api/Factories/ShoeFactory.cs)
    * [WatchFactory - DIP,("SRP")](designpatterns_api/Factories/WatchFactory.cs)
    * [IProduct - ISP](designpatterns_api/Interfaces/IProduct.cs)
    * [IShoe - LSP](designpatterns_api/Interfaces/IShoe.cs)
    * [IWatch - LSP](designpatterns_api/Interfaces/IWatch.cs)
    * [BaseProduct - LSP,(DRY)](designpatterns_api/Models/BaseProduct.cs)
    * [IShoeService - SOLID(almost)](designpatterns_api/Services/IShoeService.cs)
    ___