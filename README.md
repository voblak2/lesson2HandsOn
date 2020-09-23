# lesson2HandsOn

Lesson 2 Practice Hands-On
Directions
For your Lesson 2 Practice Hands-On, you will be practicing your new skills learned in this lesson. This Hands-On will not be graded, but we encourage you to complete it. The best way to become a great programmer is to practice! This Hands-On is broken down into three parts, so be sure to complete all requirements. Once you have submitted your project, you will be able to access the solution on the next page. Follow the below steps for setup.

Setup
Open up your command prompt/terminal.
Run the following to navigate to your Desktop
cd desktop
Navigate into the ProgrammingC# folder:
cd ProgrammingC#
Next, the following command is the CLI command to create a new project:
dotnet new console -o lesson2HandsOn
Once the process is complete, navigate into the lesson2HandsOn directory:
cd lesson2HandsOn
Lastly, run the following to open your new project in VS Code:
code .
For this Hands-On, you will be working within the Program.cs file. Good luck!

Part 1
Create a program which prints the ticket prices for a user:

If the user is a senior citizen (they are 65 years of age or older), they receive a discounted price of $7 per ticket.
If the user is 12 years of age or younger, they receive a discounted price of $8 per ticket.
Otherwise, they will pay $10.
Age Range	Price
0-12	$8
13-64	$10
65 & Above	$7
Below is starter code to help you get started. Give the variable age any value you would like to test your code:

int age;

// if senior citizen, pay $7

// if child, pay $8

// everyone else, pay $10

Tip!
Print the ticket prices to the console.

Part 2
Add the following to your program that prints the ticket prices for a user:

Create a new variable named isStudent that is of type boolean.
Set this to true to test your code.
Add another condition to the statement(s) checking for the age of a child. It should now be the following:
If the user is 12 years of age or younger OR a student, they receive a discounted price of $8 per ticket.
Age Range	Price
Student	$8
0-12	$8
13-64	$10
65 & Above	$7
Starter Code:

int age;

// if senior citizen, pay $7

// if student, pay $8

// if child, pay $8

// everyone else, pay $10

Part 3
Add the following to your program that prints the ticket prices for a user:

Add another test that checks for any negative values for the variable age. If age is indeed set to a negative value, print "Invalid age" to the console.
