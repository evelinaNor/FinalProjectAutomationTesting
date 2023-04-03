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