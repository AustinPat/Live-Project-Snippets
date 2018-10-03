# Live-Project-Snippets
This is a existing website that I worked on using C# ASP.NET MVC. 

## Checkboxes
I start off by deleting two [checkboxes](https://github.com/AustinPat/Live-Project-Snippets/blob/master/Checkboxes) in the view, and then setting there values to false automatically.

## Account Verification
Then I created an [if statement](https://github.com/AustinPat/Live-Project-Snippets/blob/master/User%20Verification) that made it so a user can only create a new student account if they already had an account in the LMS.
I also added a message that said they must be signed into the LMS to make an account then made it a link to the create an account page.

This is what the page looks like if the user is not logged into the LMS.
I also cleaned up the page by shortening the width of the input fields, positioning the words, and adding the contact checkbox message. (I also did this for all the other pages but they look very similar.)

![If Statement](https://github.com/AustinPat/Live-Project-Snippets/blob/master/Screenshot%20(13).png)

## New Properties
Here I added two [new properties](https://github.com/AustinPat/Live-Project-Snippets/blob/master/New%20Properties)
to the Analytics ViewModel. Then I added the properties to the constructor. Then in the controller I made the properties calculate the most frequently applied to company, and the most applied to job category in the database.

## Drop Down Menu
This is a [drop down menu](https://github.com/AustinPat/Live-Project-Snippets/new/master) I added to the JPBulletins view.

This is what the dropdown menu looks like
![Drop Down](https://github.com/AustinPat/Live-Project-Snippets/blob/master/Screenshot%20(26).png)

## Statements

[Here]https://github.com/AustinPat/Live-Project-Snippets/blob/master/Statements() I calculated how many applications a user has sent, and how many more they need to send until they reach 35.

This is what it looks like in the view.

![Applications](https://github.com/AustinPat/Live-Project-Snippets/blob/master/Screenshot%20(29).png)

## New Model

This is a [new model]() I created called JPChecklist, and then I pushed a migration for it.
