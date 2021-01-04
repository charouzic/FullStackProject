# Web App for getting Fibonacci Number

## Table of Contents
* [General Info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Further Steps](#further-steps)
* [TODO](#todo)

## General Info
This repository contains a fullstack app. Backend is written in C# .NET Core and creates REST API endpoints. 
These endpoints are implemented in frontend written in Angular (Typescript, Html, Css). For every push and 
pull request to main branch there is a CI pipeline implementing Github Actions. It checks both angular and 
.NET Core project for possible errors in the code and the results can be checked in the Actions tab.

## Technologies
* C# .NET Core
* Angular
* Typescript
* HTML & CSS
* Github Actions for CI

## Setup
Steps for running the project locally:
1. Clone the whole repository locally
   ```
   git clone https://github.com/charouzic/FullStackProject.git
   ```
   
2. Make sure you are in the main repo - you can do so by calling
   ```
   git status
   ```
   
3. Navigate to .NET project folder (FibonacciNumber) and run 
   ```
   dotnet run
   ```
   (make sure that dotnet is installed on your local computer)
   
4. Navigate to Angular project folder (AngularAPIApp) and run
   ```
   ng serve
   ```
   (make sure that node.js and angular CLI is installed on your local computer)
   
5. go to your browser and the project runs on the http://localhost:4200
   (make sure that Cross-origin resource sharing is allowed - if you are not sure use thos extension
   https://chrome.google.com/webstore/detail/allow-cors-access-control/lhobafahddgcelffkeicbaginigeejlf/related?hl=en)
   
## Features
This simple app allows you to get a Fibonacci number based on sequence you input in the web UI.

Endpoints:
* GET /compute/n 
(n is sequence of the Fibonacci)

* GET /fib_num 
(returns list of Fibonacci numbers from the mock database)

* GET /fib_num/n
(n is sequence of the Fibonacci)

* PUT /fib_num/n_m
(n is sequence of Fibonacci and m is value)

* DELETE /fib_num/n
(n is sequence of Fibonacci)

 
 ## Further Steps
The main focus was put on the endpoint GET /compute/n and its implementation in Angular hence the other endpoints are created but their behaviour is not 100% correct. Also the project is missing database which could be used for storing, deleting and retrieving the Fibonacci numbers. Once such database is connected, the endpoint /compute/n could be changed to first search in the database for the Fibonacci and afterwards (if the desired number is not there) compute its value - this saves the computational power used and makes the solution more effective. After all the endpoints are sucessfully designed, they can be implemented in the frontend as a further step so the application is complete. Last but not least there is a space for improvement in the user interface and design of the frontend which is plain HTML without any Bootstrap or CSS formatting. 

## TODO
- Fix the architecture especially of the back-end.
- Do not call the API within component in Angular.
