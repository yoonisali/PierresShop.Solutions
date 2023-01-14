# _Pierre's Shop_

#### By: _**Yoonis Ali**_

#### _A C# application that demonstartes the many to many relationship with login and authentication using Identity.

## Technologies Used

* _C#_
* _HTMl_
* _CSS_
* _.NET 6_
* _ASP.NET Core MVC 6_
* _Entity Framework Core_
* _MySql_


## Description

_This project will allow the user to view, create, update, or delete flavors and treats. The user must first create an account and login before they can do any of these things._

## Setup/Installation Requirements

* _Clone the repository to your desktop from: https://github.com/yoonisali/PierresShop.Solutions.git_
* _Create appsettings.json file in the PierresShop folder._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=pierres_shop;uid=root;pwd=epicodus;"
  }
}
```
* _Run the dotnet commands below in RecipeBox._
```
dotnet restore
```
```
dotnet ef database update
```
```
dotnet watch run
```

## Known Bugs

* _None_


## License

_Copyright (c) 2022 Yoonis Ali_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
