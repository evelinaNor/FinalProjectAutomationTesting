# FinalProjectAutomationTesting

### Automation testing for [IKEA website](https://www.ikea.com/se/sv/).

- **1 Scenario: Autocomplete in search bar**
   - 1.1. Test case: Search bar correctly displays suggested search queries as the user types.
     - 1.1.1 Step: Navigate to the search bar
     - 1.1.2 Step: Begin typing a search query, such as "bo"
     - 1.1.3 Step: Observe that suggested list words contain "bo" query
   
   Expected Result: The search bar displays a list of suggested search queries related to "bo" input: "bord", "boaxel", "bokhylla", "bordslampa".

- **2 Scenario: Product filtering by "Color"**
   - 2.1. Test case: Product filtering feature filters products accurately using "Color" applied filter.
     - 2.1.1 Step: Navigate to the product list filtering section
     - 2.1.2 Step: Click on (Färg) filter
     - 2.1.3 Step: Select color
   
   Expected Result: Products are filtered on the page according to selection.

- **3 Scenario: Add to cart function**
   - 3.1. Test case: User can add a product to their cart.
     - 3.1.1 Step: Navigate to the product page
     - 3.1.2 Step: Click on the item in a product list
     - 3.1.3 Step: Enter quantity "2"
     - 3.1.4 Step: Click on add to cart (Lägg i varukorg) button
     - 3.1.5 Step: Navigate to the cart page by clicking continue to the cart (Fortsätt till varukorgen) link
   
   Expected Result: The cart summary reflects added products quantity.

- **4 Scenario: Registration page validation**
   - 4.1. Test case: The registration page correctly validates user input and creates a new user account.
     - 4.1.1 Step: Open the registration form
     - 4.1.2 Step: Select second option for not becoming IKEA Family member
     - 4.1.3 Step: Tick on checkbox ("Jag har inget svenskt personnummer")
     - 4.1.3 Step: Fill all input fields with a valid data
     - 4.1.4 Step: Tick on checkbox ("Jag har läst och förstått IKEA Integritetspolicy")
     - 4.1.5 Step: Click on go further (Gå vidare) button
   
   Expected Result: Side banner appears with information to verify email.

- **5 Scenario: Login functionality validation**
   - 5.1. Test case: The login functionality allows users to access their accounts.
     - 5.1.1 Step: Open login page
     - 5.1.2 Step: Enter valid email
     - 5.1.3 Step: Enter valid password
     - 5.1.4 Step: Click the continue (Fortsätt) button

   Expected Result: The user is logged in successfully and the user is redirected to the homepage.

- **6 Scenario: Product list sorting**
   - 6.1. Test case: Sort the product list from Low to High price.
     - 6.1.1 Step: Navigate to the product list
     - 6.1.2 Step: Click on (Sortera) filter
     - 6.1.3 Step: Select (Pris: lågt till högt) option

   Expected Result: Products are sorted from Low to High price.