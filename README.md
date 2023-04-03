# FinalProjectAutomationTesting

Automation testing for [IKEA website](https://www.ikea.com/se/sv/).

- 1 Scenario: Autocomplete in search bar
   - 1.1. Test case: Ensure that the search bar correctly displays suggested search queries as the user types.
     - 1.1.1 Step: Open the search bar
     - 1.1.2 Step: Begin typing a search query, such as "tab"
     - 1.1.3 Step: Observe the suggested search queries that appear
   
   Expected Result: The search bar displays a list of suggested search queries related to the user's input, such as "table and chairs", "table", "table lamp" etc.
 
- 2 Scenario: Basic search in search bar
   - 2.1. Test case: Ensure that the search bar correctly displays search results for a basic search query.
     - 2.1.1 Step: Open the search bar
     - 2.1.2 Step: Enter a basic search query, such as "lamps"
     - 2.1.3 Step: Press the search button
   
   Expected Result: The search results display all products related to the search query "lamps".
   
- 3 Scenario: Multiple filters in product display page
   - 3.1. Test case: Test to ensure the product filtering feature correctly filters products based on multiple filters applied at the same time.
     - 3.1.1 Step: Navigate to the product list filtering section
     - 3.1.2 Step: Select multiple filters such as price range, color, and type
     - 3.1.3 Step: Verify that the products on the page are automatically filtered by the selected price range, color, and type
   
   Expected Result: The filtered products displayed on the page meet all of the selected filtering criteria.

- 4 Scenario: Add to cart function
   - 4.1. Test case: Check if user can add a product to their cart.
     - 4.1.1 Step: Navigate to the product page
     - 4.1.2 Step: Click on the first item in a product list
     - 4.1.3 Step: Navigate to the cart page to view the cart summary
   
   Expected Result: The product is added to the cart and the cart summary reflects the updated total number of items in the cart.

- 5 Scenario: Registration page validation
   - 5.1. Test case: Verify that the registration page correctly validates user input and creates a new user account.
     - 5.1.1 Step: Navigate to the registration form
     - 5.1.2 Step: Select first option for becoming IKEA Family member
     - 5.1.3 Step: Fill all input fields with valid data
     - 5.1.4 Step: Select first 2 checkboxes for IKEA Policy and Terms of Use
     - 5.1.5 Step: Click on "Gå vidare" button
     - 5.1.6 Step: Verify that the user is redirected to a confirmation page
     - 5.1.7 Step: Verify that a new user account is created with the entered information
   
   Expected Result: The user's account is created successfully and the user can log in with the entered email address and password.
