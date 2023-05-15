# FinalProjectAutomationTesting

### Automation testing for [IKEA website](https://www.ikea.com/se/sv/).

- **1 Scenario: Autocomplete in search bar**
   - 1.1. Test case: Search bar correctly displays suggested search queries as the user types.
     - 1.1.1 Step: Navigate to the search bar
     - 1.1.2 Step: Begin typing a search query, such as "bo"
     - 1.1.3 Step: Observe that suggested list words contain "bo" query
   
   Expected Result: The search bar displays a list of suggested search queries related to "bo" input: "bord", "boaxel", "bokhylla", "bordslampa".
 
- **2 Scenario: Basic search in search bar**
   - 2.1. Test case: Correct search results from a basic search query.
     - 2.1.1 Step: Navigate to the search bar
     - 2.1.2 Step: Enter a basic search query "taklampa"
     - 2.1.3 Step: Press the search (Sök) icon
   
   Expected Result: The search results display all products related to the search query "taklampa".
   
- **3 Scenario: Multiple filters in product display page**
   - 3.1. Test case: Product filtering feature filters products accurately using multiple applied filters.
     - 3.1.1 Step: Navigate to the product list filtering section
     - 3.1.2 Step: Choose price (Pris)
     - 3.1.3 Step: Choose any available color (Färg)
   
   Expected Result: Applied filters automatically sort products on the page according to chosen filters.

- **4 Scenario: Add to cart function**
   - 4.1. Test case: User can add a product to their cart.
     - 4.1.1 Step: Navigate to the first product page
     - 4.1.2 Step: Click on the first item in a product list
     - 4.1.3 Step: Click on add to cart (Lägg i varukorg) button
     - 4.1.4 Step: Navigate to the cart page by clicking continue to the cart (Fortsätt till varukorgen)
   
   Expected Result: The product is added to the cart and the cart summary reflects the number of added products.

- **5 Scenario: Registration page validation**
   - 5.1. Test case: The registration page correctly validates user input and creates a new user account.
     - 5.1.1 Step: Open the registration form
     - 5.1.2 Step: Select second option for not becoming IKEA Family member
     - 5.1.3 Step: Tick on checkbox ("Jag har inget svenskt personnummer")
     - 5.1.3 Step: Fill all input fields with valid data
     - 5.1.4 Step: Tick on checkbox ("Jag har läst och förstått IKEA Integritetspolicy")
     - 5.1.5 Step: Click on go further (Gå vidare) button
   
   Expected Result: Side banner appears with information to verify email.

- **6 Scenario: Login functionality validation**
   - 6.1. Test case: The login functionality allows users to access their accounts.
     - 6.1.1 Step: Open login page
     - 6.1.2 Step: Enter valid email
     - 6.1.3 Step: Enter valid password
     - 6.1.4 Step: Click the continue (Fortsätt) button

   Expected Result: The user is logged in successfully and the user is redirected to the homepage.