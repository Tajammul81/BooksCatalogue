   Environment and Development
   ========================================================


   
This project was generated in Visual Studio 2017.In order to run this project you need 
   to have full version of Visual studio 2017 and a Microsoft Operation System.


  Running Server and Endpoint
  ==========================================================
   Server

Run IISExpress on Internet Explorer but should be able to run on any microsoft
   competable browser for user interface.
   By running the project you need to navigate http://localhost:50290/Catalog/Index

  Required dependecies and C# libraries
  ==========================================================
  The following required to run the project( setup from the beginning)
  using System.Linq;
  using System.Net;
  using System.Net.Http;
  using System.Web.Http;
  using System.Xml.Linq;

  Functionality
  ==========================================================
  A potential user upon successfully running the API with http://localhost:50290/Catalog/Index 
  will be promoted to the page with a search box. At first glance the user will be able to
  see all the books in a tabular form with title, author, genre, price, publish_date and 
  description. The user can search a book by title by either entering at least one letter
  or more.After writing a letter or letters i.e. either in small or big letters in search
  box a user need to click on search. 
  The relevent information regarding the book search will be displayed in the table. If a 
  user want to get the whole catalogue, a clear button click will get back a user to the
  whole catalogue of books.

  Running unit tests

Run
  ===========================================================
  A unit testing is there however I could have added more details in there if required.



