# Pierre's Bakery Vendor Tracker

#### By Kirsten Opstad 

#### A Vendor and Order Tracker for a fictional bakery.

## Technologies Used

* C#
* .Net 6
* ASP.Net Core 6 MVC

## Description

A student project demonstrating knowledge of building web apps with C#/.Net using test-driven development and RESTful routing best practices.

### Objectives (MVP)

Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors.

For example, Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships.

Use Razor to display information on each page.

* Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include. ✅
* Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include. ✅
* The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page. ✅
* The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage. ✅
* Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders. ✅
* Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new". ✅

Additionally, code will be reviewed for the following objectives:

* A splash page is used. ✅
* Project has Vendor and Order classes. ✅
* Project uses two or more controllers. ✅
* Models are thoroughly tested. ✅
* GET and POST requests/responses are used successfully. ✅
* MVC routes follow RESTful conventions. ✅
* Project is in a polished, portfolio-quality state. 
* The prompt’s required functionality and baseline project requirements are in place by the deadline.

<!-- [x] Screenshots

![Screenshots](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.03bZmDGXaBhBYyxxp3Ls3gHaEA%26pid%3DApi&f=1&ipt=e980d57210242747a51c41421e1f09a6de3b1fdaeaadd297496787bb64e80c88&ipo=images) -->

<!-- [Link to operational site](http://www.kirstenopstad.github.com/<REPOSITORY NAME>) -->

### Goals
1. Meet MVP
2. Allow Pierre to click an Order's name to go to a separate page to view its details.
3. Add the ability to delete individual Vendors, all Orders belonging to a Vendor, individual Orders, or all Vendors.
4. Add the ability to update Vendor or Order details.
5. Add the ability for Pierre to note whether an order has been paid for or not.
6. Add custom CSS and JavaScript.
7. Add search functionality to your app.

## Setup/Installation Requirements

* Clone this repo to your workspace.
* Navigate to the top level of the directory.
* Navigate to program directory ``` $ cd VendorOrder ```
* To run tests ``` $ dotnet test VendorOrder.Tests ```
* To build & run program in development mode ``` $ dotnet run ```
* To build & run program in production mode ``` dotnet run --launch-profile "production" ```

## Known Bugs

* No known bugs. If you find one, please email me at kirsten.opstad@gmail.com with the subject **[_Repo Name_] Bug** and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

## License
<!-- [Choose License](https://choosealicense.com/) -->

MIT License

Copyright (c) 2022 Kirsten Opstad

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
