## Project: **Week 11 Code Review - Claire's Hairs Pairs (Stylists and Clients)**
#### Author: **Christopher Huber**

### Github page: https://github.com/CHuber42/Fri-5-29-Code-Review
#### Github repo: You're standing on it.
##### Copyright Christopher Huber, 2020

&nbsp;
     
&nbsp;
         
##### Build instructions/Installation: 

This project is built in C# 8.0 using .netcoreapp2.2 on a system running Ubuntu 18.04.
Dependencies are declared in the HairSalon.csproj and HairSalon.Tests.csproj files in their respective folders.
.NetCoreApp 2.2 Framework is required.

To install, simply clone (or download) this folder into a new directory, git bash to HairSalon.Solution/HairSalon/ folder,
and run dotnet restore.

To run: either build the project using dotnet build and run the .exe, or navigate to the
HairSalon.Solution/HairSalon/ folder in a terminal and enter "dotnet run"

##### Development Description:

As the salon owner, I need to be able to see a list of all stylists.
As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
As the salon owner, I need to add new stylists to our system when they are hired.
As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.

##### Development specs:

** Construction process: **
** HomeController has Index() route to serve as home/landing/splash page ** 
** Home/Index.cshtml redirects to StylistsController/Index() Route **
** Above Route returns Stylists/Index.cshtml View **
** Above View has 'Create New Stylist' ActionLink **
** Above Link leads to Create() route in stylistscontroller **
** Create() Route from 7. leads to Create.Cshtml View in Stylists views **
** View from 8. has a form to fill out to take in a new stylist's details, and returns that form to [httppost] Create() route in stylists controller **
** Route from 9. creates a entry in the db with the taken-in info, and saves it. Then redirects to stylists index view **
** Alter stylists Index() route to query database and gather all stylists into list, serve list to index as model **
** Alter Index.cshtml view in stylists to loop over list and display actionlinks for each entry (stylist) in the list **
** Each clickable stylist dynamically routes to stylists controller based on stylist ID **
** Dynamic route in stylistcontroller uses passed-in Id from index to find stylist in db (or pass along object from list directly?) **
** Query database based on Stylist Id from 14. to find all clients that belong to it (has a matching stylist id in the table). Return them as list. **
** Route from 14 directs to details.cshtml view in stylists, passing list from 15 as model(perhaps within stylist as model?) **
** Display Stylist name as header, loop over clients list to display them **
** Include in details.cshtml option to add new client to db for this stylist; routes to Create() in ClientsController **
** Route from 18 queries db entries of stylists, adds them to list, redirects to Create.cshtml view with list as model **
** View from 19. offers form to create new client. Select/dropdown box uses model's list to offer selections of stylists to assign this client to **
** Submit of form from 20. routes to ClientsController create() (as post) route. Adds entry to db, reroutes to StylistController Index() route ** 

##### Stretch Goals 

** Add Nav Bar

##### _Contact_:

CHuber42.Gmail.com

##### _Copyright Christopher Huber 2020, all rights reserved._







