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
