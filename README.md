# TManager
Making Time Management Easier
________________

MOTIVATION: the reason for the creation of the application is to help students manage their
semester by making sure they are aware of the modules they take, how much studying is required
and how much progress they have made with their studies.
______________________________________________________________________________________________

The Features I will add in the future:
In the future, I will add a progress bar to track if the user hits a miletsone.
so Milestones will be implemented in the application. as well as a graph to display study hours
per day and how much was done.
______________________________________________________________________________________________

Challeneges: There was a challenge in calculating remaining study hours and study hours required.
hourstudied is captured but nr_of weeks remains null. calculating study hours required will
generate an error in the application. as well as calculating remaining study hours.
________________________________________________________________________________________________

How to use:

The Application Features, with how the pages flow:
1. Home page(start page)
2. depending on what you choose, if you choose...
   if (Login is chosen){
	you will enter the login page
   }
3. From Here, SignUp Page can be accessed by clicking "Sign Up here"
4. from Signup page, you can make yourself a user. to go back to login page,
   press "log in" at the bottom of the signup form. this is after you press the create button
   , once you have entered all your details .
5. Now we are back to the login. enter your email and password to log in.
6. if(log in details are valid){
     The next feature you will see is the dashboard
   }
   otherwise {
   you can use the defualt user details below:
      Rojas@gmail.com(email)
      Jos@1234(password)
   that is if you just interested in seeing the pages after log in.
   }
7. after logging in successfully, you will be in the dashboard.
8. Dashboard has 2 options:
	-MyModules
	-AddModules
9. if(you choose Mymodule) then{
   you will see a list of modules 
   }
10. you can add a module by pressing the "Create" link at the top of the list.
	This will take you to the addModules page to create a module.
11. after clicking the create button, once you have entered module information, 
     go back to the list of modules.
12.  at the list (MyModules): 
	-to delete, press"Delete"
	-to update info on a specific module, press"Update"
	-for study hours, press "study hours"
13. Log out button is at the top righ corner of the dashboard page.
    This will take you back to the login page
_______________________________________________________________________________________________
Framework used:

Asp.net (.net framework)
Entity Framework

_______________________________________________________________________________________________
Installation:
-make sure to download visual studio
Once you are done...

in your project folder(where ever you have stored the file).
- double click the project folder. the name of the c# file is
	PROG6212 Poe Joseph 20104412.sln 
-visual studio will open the file.
	to download the libraries:
   1. right click properties and press "Manage NuGet Packages" option.
   2. in the NuGet page, click browse and search and download the following:
	-Entity Framwork 6.0.0/ latest
	-Bootstrap 3.4.1

To install the class library of the application(should it not be available):
right click references:
	click add reference
	click browse 
	find the class library, it is called: ClassLibraryForPoe
	double click the file
	double the file the file with the same again: ClassLibraryForPoe
	double click bin
	double click debug
	you will find a file called ClassLibraryForPoe.dll. select it and press ok.
then the class library can be accessed. But most likey the class library is there.
________________________________________________________________________________________________
Type of application pattern:
MVC (Model View Controller)



