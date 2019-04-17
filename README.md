Niema Attarian ~ 
G00346901@gmit.ie ~ 
G00346901

# OverView
My third year mobile application project consisted of creating a cross platform application using Xamarin and Visual studios which deploys to Android, iOS and Windows (Universal Windows Platform). The application incorporates a well designed UI that is fit for the purpose and provides a good user experience and uses data storage (JSON). My application is a music application which allow users to creat artists, delete and append them in a list view.

# Design Document of the Project and Implementations
Upon running this project the 'MainPage' is that of a home page containing the list on the left where the 'Artists' and their respective information is displayed. In the middle shows where you can edit the information of the 'Artist' if one is selected.

If an 'Artist' is selected (double clicked) you are brought to a page which displays the information.

At the bottom there are a number of available buttons with different functionalities (Save, Delete, Add).

~ The 'Save' button functionality allows the user to save any information they have edited from the list of artists on the left of the screen. This is updated in the JSON.

~ The 'Delete' button functionality allows the user to delete an artist selected from the list along the left-hand side of the home-screen. This is also updated in the JSON.

~ The 'Add' button functionality brings the user to a seperate add page where they can add an artist of their choice with their repective information such as (String) Album, (String) Genre, (Int) Sales. This is then saved to JSON and displayed to the left of the screen with the rest of the artists in the list.
There are problems with the add function as I believe it does not add correctly.

# Test Cases
### Test Case 1 - Update
1) Click on a selected artist.
2) Observe that the information is shown in the middle of the page in entry boxes.
3) Change preferred information in entry boxes.
4) Click the 'Save' button to save the information edited.

#### Expcted Outcome:
The information is changed and updated accordingly.

#### Actual Outcome:
The information is changed and updated accordingly.

### Test Passed ✔

### Test Case 2 - Delete
1) Chose prefered 'Artist' from list along the left.
2) Click the 'Delete' button.

#### Expected Outcome: 
The information should be deleted.

#### Actual Outcome:
The information is deleted.

### Test Passed ✔

### Test Case 3 - Add
1) Select 'Add' button to enter add page.
2) Enter prefered information to add an artist.
3) Click 'Save' button to save information and add it to the list.

#### Expected Outcome: 
The information is added to the list.

#### Actual Outcome: 
The information isn't added to the list. The test fails at third step.

### Test Failed ✘


