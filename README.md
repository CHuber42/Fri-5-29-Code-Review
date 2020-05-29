** Specs description: Similar to previous' days work; essentially, rebuild "ToDoList" or "Animal Shelter" or "Best Restaurants" but with hair salon motif. **
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
