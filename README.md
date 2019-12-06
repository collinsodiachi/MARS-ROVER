Scope to the solution of this exercise

The Mars-Rover-app has two parts. The server side which is
built with dotnet core 2.1x and client side built with Angular 8

On the server side, HttpClient factory is used to call the  Mars rovers Opportunity
API. 

Date input is read from the text file found at the root of the Mar-Rover application. Date is dynamically populated on the view and are used as parameter to make request to the API.
Date is parsed to Mars-Rover-app API acceptable format. Note that April 31, 2018 is an invalid 
date format and therefore throws error that is handle and represented on the view.
You can also get more photos by adding more dates to the text file "Date.txt"

Mars Rover photos are processed and saved locally to the local TEMP folder
see path: C:\Users\users-name\AppData\Local\Temp. Photos saves at each request made 
before rendering to the View.

On the client side side, HttpClient  is used to call the  Mars-rover-app API. 
Data from Angular service directory is consumed at nasa-image component and image is presented at the view.

Know possible Areas of limitations that can be Improved
1)  Since unit testing was a bonus, I did not bother to include it now because time is also a factor
    but end to end test was thoroughly performed. I will be adding unit test in the future.

2) Global error handling and implementing of custom middleware was not implemented in this application. But errors where handled using try and catch for most part. I will be adding a global 
custom middleware to catch every error that is thrown and handled properly.

3) This application calls the Mars Rover API at every request. In the future I will be implement in the app to look for already existing photos in the local directory before sending request to the API.
This will save cost, in time and http request

4) Routing can be implemented properly on the client side in the future 

Building App Locally
Install Node.js 12.x
install Dotnet core 2.1x
