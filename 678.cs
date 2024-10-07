Rzor pages steps: 

1: make a razor page app
2: make folder called Modles and add ur .cs class that will have ur data model 
3: go into pages and make a folder of whatever you want, add an s (optional)
4: go to nuget package manger and install entity framwork core and install for sql server
5: once installed right click and add rzor page to the folder that you just made
6: click the file that u want as the framework and add a new context for the thingy
7: let it cook 
8: nuget package manager console and type : 
add-migration InitData
update-database
9: opne the project in express (https also works?)



using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
public class Employee
{
[Required]
[Key]
public int EmpId { get; set; }
[Required]
[StringLength(20,ErrorMessage ="<20")]
public string Name { get; set; }
[Phone]
public string Phone { get; set; }
}
}

@page
@model IndexModel
@{
ViewData["Title"] = "Home page";
}
<div class="text-center">
<h1 class="display-4">Welcome to our Truffle Food Services</h1>
<img src="~/hoste1.png" runat="server" alt="image" /><br /><br />
<a href="/Students" class="btn btn-primary mt-2">Explare the menu here!</a>
</div>


Adding features to the employee website
Code:
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace PracticeWebsite.Models
{
 public class Employee
 {
 [Key]
 [MinLength(6), MaxLength(6)]
 public int EmpId { get; set; }
 [Required]
 [StringLength(50,MinimumLength = 3,ErrorMessage ="Name should not be less
then 3 characters")]
 public string Name { get; set; }
 [Phone]
 public string Phone { get; set; }
 [Required]
 [EmailAddress]
 public string EmailAddress { get; set;}
 }
}
