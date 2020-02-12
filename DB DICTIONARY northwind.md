# Dictionary for database `northwind`

- Server: PostgreSQL `localhost:5434`, version `12.0`
- Local timestamp: `2020-02-12T12:30:57.7961930+01:00`
- Schemas: `public`

## Table of Contents

- Table [`public.categories`](#table-publiccategories)
- Table [`public.customer_customer_demo`](#table-publiccustomer_customer_demo)
- Table [`public.customer_demographics`](#table-publiccustomer_demographics)
- Table [`public.customers`](#table-publiccustomers)
- Table [`public.employee_territories`](#table-publicemployee_territories)
- Table [`public.employees`](#table-publicemployees)
- Table [`public.order_details`](#table-publicorder_details)
- Table [`public.orders`](#table-publicorders)
- Table [`public.products`](#table-publicproducts)
- Table [`public.region`](#table-publicregion)
- Table [`public.shippers`](#table-publicshippers)
- Table [`public.suppliers`](#table-publicsuppliers)
- Table [`public.territories`](#table-publicterritories)
- Table [`public.us_states`](#table-publicus_states)

## Tables

### Table `public.categories`

<!-- comment on table public.categories is @until-end-tag; -->
Table of categories. Here you can find all the categories.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-categories-category_id" href="#public-categories-category_id">#</a>`category_id` | **PK** | `smallint` | **NO** |  | <!-- comment on column public.categories.category_id is @until-end-tag; -->Primary key for table categories<!-- end --> |
| <a id="user-content-public-categories-category_name" href="#public-categories-category_name">#</a>`category_name` |  | `character varying(15)` | **NO** |  | <!-- comment on column public.categories.category_name is @until-end-tag; -->Name of the category<!-- end --> |
| <a id="user-content-public-categories-description" href="#public-categories-description">#</a>`description` |  | `text` | YES |  | <!-- comment on column public.categories.description is @until-end-tag; -->Category description.<!-- end --> |
| <a id="user-content-public-categories-picture" href="#public-categories-picture">#</a>`picture` |  | `bytea` | YES |  | <!-- comment on column public.categories.picture is @until-end-tag; -->Binary content of category picture<!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.customer_customer_demo`

<!-- comment on table public.customer_customer_demo is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-customer_customer_demo-customer_id" href="#public-customer_customer_demo-customer_id">#</a>`customer_id` | **PK**, **FK [➝](#public-customers-customer_id) `customers.customer_id`** | `character` | **NO** |  | <!-- comment on column public.customer_customer_demo.customer_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer_customer_demo-customer_type_id" href="#public-customer_customer_demo-customer_type_id">#</a>`customer_type_id` | **PK**, **FK [➝](#public-customer_demographics-customer_type_id) `customer_demographics.customer_type_id`** | `character` | **NO** |  | <!-- comment on column public.customer_customer_demo.customer_type_id is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.customer_demographics`

<!-- comment on table public.customer_demographics is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-customer_demographics-customer_type_id" href="#public-customer_demographics-customer_type_id">#</a>`customer_type_id` | **PK** | `character` | **NO** |  | <!-- comment on column public.customer_demographics.customer_type_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer_demographics-customer_desc" href="#public-customer_demographics-customer_desc">#</a>`customer_desc` |  | `text` | YES |  | <!-- comment on column public.customer_demographics.customer_desc is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.customers`

<!-- comment on table public.customers is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-customers-customer_id" href="#public-customers-customer_id">#</a>`customer_id` | **PK** | `character` | **NO** |  | <!-- comment on column public.customers.customer_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-company_name" href="#public-customers-company_name">#</a>`company_name` |  | `character varying(40)` | **NO** |  | <!-- comment on column public.customers.company_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-contact_name" href="#public-customers-contact_name">#</a>`contact_name` |  | `character varying(30)` | YES |  | <!-- comment on column public.customers.contact_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-contact_title" href="#public-customers-contact_title">#</a>`contact_title` |  | `character varying(30)` | YES |  | <!-- comment on column public.customers.contact_title is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-address" href="#public-customers-address">#</a>`address` |  | `character varying(60)` | YES |  | <!-- comment on column public.customers.address is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-city" href="#public-customers-city">#</a>`city` |  | `character varying(15)` | YES |  | <!-- comment on column public.customers.city is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-region" href="#public-customers-region">#</a>`region` |  | `character varying(15)` | YES |  | <!-- comment on column public.customers.region is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-postal_code" href="#public-customers-postal_code">#</a>`postal_code` |  | `character varying(10)` | YES |  | <!-- comment on column public.customers.postal_code is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-country" href="#public-customers-country">#</a>`country` |  | `character varying(15)` | YES |  | <!-- comment on column public.customers.country is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-phone" href="#public-customers-phone">#</a>`phone` |  | `character varying(24)` | YES |  | <!-- comment on column public.customers.phone is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customers-fax" href="#public-customers-fax">#</a>`fax` |  | `character varying(24)` | YES |  | <!-- comment on column public.customers.fax is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.employee_territories`

<!-- comment on table public.employee_territories is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-employee_territories-employee_id" href="#public-employee_territories-employee_id">#</a>`employee_id` | **PK**, **FK [➝](#public-employees-employee_id) `employees.employee_id`** | `smallint` | **NO** |  | <!-- comment on column public.employee_territories.employee_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employee_territories-territory_id" href="#public-employee_territories-territory_id">#</a>`territory_id` | **PK**, **FK [➝](#public-territories-territory_id) `territories.territory_id`** | `character varying(20)` | **NO** |  | <!-- comment on column public.employee_territories.territory_id is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.employees`

<!-- comment on table public.employees is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-employees-employee_id" href="#public-employees-employee_id">#</a>`employee_id` | **PK** | `smallint` | **NO** |  | <!-- comment on column public.employees.employee_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-last_name" href="#public-employees-last_name">#</a>`last_name` |  | `character varying(20)` | **NO** |  | <!-- comment on column public.employees.last_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-first_name" href="#public-employees-first_name">#</a>`first_name` |  | `character varying(10)` | **NO** |  | <!-- comment on column public.employees.first_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-title" href="#public-employees-title">#</a>`title` |  | `character varying(30)` | YES |  | <!-- comment on column public.employees.title is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-title_of_courtesy" href="#public-employees-title_of_courtesy">#</a>`title_of_courtesy` |  | `character varying(25)` | YES |  | <!-- comment on column public.employees.title_of_courtesy is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-birth_date" href="#public-employees-birth_date">#</a>`birth_date` |  | `date` | YES |  | <!-- comment on column public.employees.birth_date is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-hire_date" href="#public-employees-hire_date">#</a>`hire_date` |  | `date` | YES |  | <!-- comment on column public.employees.hire_date is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-address" href="#public-employees-address">#</a>`address` |  | `character varying(60)` | YES |  | <!-- comment on column public.employees.address is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-city" href="#public-employees-city">#</a>`city` |  | `character varying(15)` | YES |  | <!-- comment on column public.employees.city is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-region" href="#public-employees-region">#</a>`region` |  | `character varying(15)` | YES |  | <!-- comment on column public.employees.region is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-postal_code" href="#public-employees-postal_code">#</a>`postal_code` |  | `character varying(10)` | YES |  | <!-- comment on column public.employees.postal_code is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-country" href="#public-employees-country">#</a>`country` |  | `character varying(15)` | YES |  | <!-- comment on column public.employees.country is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-home_phone" href="#public-employees-home_phone">#</a>`home_phone` |  | `character varying(24)` | YES |  | <!-- comment on column public.employees.home_phone is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-extension" href="#public-employees-extension">#</a>`extension` |  | `character varying(4)` | YES |  | <!-- comment on column public.employees.extension is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-photo" href="#public-employees-photo">#</a>`photo` |  | `bytea` | YES |  | <!-- comment on column public.employees.photo is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-notes" href="#public-employees-notes">#</a>`notes` |  | `text` | YES |  | <!-- comment on column public.employees.notes is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-reports_to" href="#public-employees-reports_to">#</a>`reports_to` | **FK [➝](#public-employees-employee_id) `employees.employee_id`** | `smallint` | YES |  | <!-- comment on column public.employees.reports_to is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-employees-photo_path" href="#public-employees-photo_path">#</a>`photo_path` |  | `character varying(255)` | YES |  | <!-- comment on column public.employees.photo_path is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.order_details`

<!-- comment on table public.order_details is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-order_details-order_id" href="#public-order_details-order_id">#</a>`order_id` | **PK**, **FK [➝](#public-orders-order_id) `orders.order_id`** | `smallint` | **NO** |  | <!-- comment on column public.order_details.order_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-order_details-product_id" href="#public-order_details-product_id">#</a>`product_id` | **PK**, **FK [➝](#public-products-product_id) `products.product_id`** | `smallint` | **NO** |  | <!-- comment on column public.order_details.product_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-order_details-unit_price" href="#public-order_details-unit_price">#</a>`unit_price` |  | `real(24,2)` | **NO** |  | <!-- comment on column public.order_details.unit_price is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-order_details-quantity" href="#public-order_details-quantity">#</a>`quantity` |  | `smallint` | **NO** |  | <!-- comment on column public.order_details.quantity is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-order_details-discount" href="#public-order_details-discount">#</a>`discount` |  | `real(24,2)` | **NO** |  | <!-- comment on column public.order_details.discount is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.orders`

<!-- comment on table public.orders is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-orders-order_id" href="#public-orders-order_id">#</a>`order_id` | **PK** | `smallint` | **NO** |  | <!-- comment on column public.orders.order_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-customer_id" href="#public-orders-customer_id">#</a>`customer_id` | **FK [➝](#public-customers-customer_id) `customers.customer_id`** | `character` | YES |  | <!-- comment on column public.orders.customer_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-employee_id" href="#public-orders-employee_id">#</a>`employee_id` | **FK [➝](#public-employees-employee_id) `employees.employee_id`** | `smallint` | YES |  | <!-- comment on column public.orders.employee_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-order_date" href="#public-orders-order_date">#</a>`order_date` |  | `date` | YES |  | <!-- comment on column public.orders.order_date is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-required_date" href="#public-orders-required_date">#</a>`required_date` |  | `date` | YES |  | <!-- comment on column public.orders.required_date is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-shipped_date" href="#public-orders-shipped_date">#</a>`shipped_date` |  | `date` | YES |  | <!-- comment on column public.orders.shipped_date is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-ship_via" href="#public-orders-ship_via">#</a>`ship_via` | **FK [➝](#public-shippers-shipper_id) `shippers.shipper_id`** | `smallint` | YES |  | <!-- comment on column public.orders.ship_via is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-freight" href="#public-orders-freight">#</a>`freight` |  | `real(24,2)` | YES |  | <!-- comment on column public.orders.freight is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-ship_name" href="#public-orders-ship_name">#</a>`ship_name` |  | `character varying(40)` | YES |  | <!-- comment on column public.orders.ship_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-ship_address" href="#public-orders-ship_address">#</a>`ship_address` |  | `character varying(60)` | YES |  | <!-- comment on column public.orders.ship_address is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-ship_city" href="#public-orders-ship_city">#</a>`ship_city` |  | `character varying(15)` | YES |  | <!-- comment on column public.orders.ship_city is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-ship_region" href="#public-orders-ship_region">#</a>`ship_region` |  | `character varying(15)` | YES |  | <!-- comment on column public.orders.ship_region is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-ship_postal_code" href="#public-orders-ship_postal_code">#</a>`ship_postal_code` |  | `character varying(10)` | YES |  | <!-- comment on column public.orders.ship_postal_code is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-orders-ship_country" href="#public-orders-ship_country">#</a>`ship_country` |  | `character varying(15)` | YES |  | <!-- comment on column public.orders.ship_country is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.products`

<!-- comment on table public.products is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-products-product_id" href="#public-products-product_id">#</a>`product_id` | **PK** | `smallint` | **NO** |  | <!-- comment on column public.products.product_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-product_name" href="#public-products-product_name">#</a>`product_name` |  | `character varying(40)` | **NO** |  | <!-- comment on column public.products.product_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-supplier_id" href="#public-products-supplier_id">#</a>`supplier_id` | **FK [➝](#public-suppliers-supplier_id) `suppliers.supplier_id`** | `smallint` | YES |  | <!-- comment on column public.products.supplier_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-category_id" href="#public-products-category_id">#</a>`category_id` | **FK [➝](#public-categories-category_id) `categories.category_id`** | `smallint` | YES |  | <!-- comment on column public.products.category_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-quantity_per_unit" href="#public-products-quantity_per_unit">#</a>`quantity_per_unit` |  | `character varying(20)` | YES |  | <!-- comment on column public.products.quantity_per_unit is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-unit_price" href="#public-products-unit_price">#</a>`unit_price` |  | `real(24,2)` | YES |  | <!-- comment on column public.products.unit_price is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-units_in_stock" href="#public-products-units_in_stock">#</a>`units_in_stock` |  | `smallint` | YES |  | <!-- comment on column public.products.units_in_stock is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-units_on_order" href="#public-products-units_on_order">#</a>`units_on_order` |  | `smallint` | YES |  | <!-- comment on column public.products.units_on_order is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-reorder_level" href="#public-products-reorder_level">#</a>`reorder_level` |  | `smallint` | YES |  | <!-- comment on column public.products.reorder_level is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-products-discontinued" href="#public-products-discontinued">#</a>`discontinued` |  | `integer` | **NO** |  | <!-- comment on column public.products.discontinued is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.region`

<!-- comment on table public.region is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-region-region_id" href="#public-region-region_id">#</a>`region_id` | **PK** | `smallint` | **NO** |  | <!-- comment on column public.region.region_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-region-region_description" href="#public-region-region_description">#</a>`region_description` |  | `character` | **NO** |  | <!-- comment on column public.region.region_description is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.shippers`

<!-- comment on table public.shippers is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-shippers-shipper_id" href="#public-shippers-shipper_id">#</a>`shipper_id` | **PK** | `smallint` | **NO** |  | <!-- comment on column public.shippers.shipper_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-shippers-company_name" href="#public-shippers-company_name">#</a>`company_name` |  | `character varying(40)` | **NO** |  | <!-- comment on column public.shippers.company_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-shippers-phone" href="#public-shippers-phone">#</a>`phone` |  | `character varying(24)` | YES |  | <!-- comment on column public.shippers.phone is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.suppliers`

<!-- comment on table public.suppliers is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-suppliers-supplier_id" href="#public-suppliers-supplier_id">#</a>`supplier_id` | **PK** | `smallint` | **NO** |  | <!-- comment on column public.suppliers.supplier_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-company_name" href="#public-suppliers-company_name">#</a>`company_name` |  | `character varying(40)` | **NO** |  | <!-- comment on column public.suppliers.company_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-contact_name" href="#public-suppliers-contact_name">#</a>`contact_name` |  | `character varying(30)` | YES |  | <!-- comment on column public.suppliers.contact_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-contact_title" href="#public-suppliers-contact_title">#</a>`contact_title` |  | `character varying(30)` | YES |  | <!-- comment on column public.suppliers.contact_title is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-address" href="#public-suppliers-address">#</a>`address` |  | `character varying(60)` | YES |  | <!-- comment on column public.suppliers.address is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-city" href="#public-suppliers-city">#</a>`city` |  | `character varying(15)` | YES |  | <!-- comment on column public.suppliers.city is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-region" href="#public-suppliers-region">#</a>`region` |  | `character varying(15)` | YES |  | <!-- comment on column public.suppliers.region is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-postal_code" href="#public-suppliers-postal_code">#</a>`postal_code` |  | `character varying(10)` | YES |  | <!-- comment on column public.suppliers.postal_code is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-country" href="#public-suppliers-country">#</a>`country` |  | `character varying(15)` | YES |  | <!-- comment on column public.suppliers.country is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-phone" href="#public-suppliers-phone">#</a>`phone` |  | `character varying(24)` | YES |  | <!-- comment on column public.suppliers.phone is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-fax" href="#public-suppliers-fax">#</a>`fax` |  | `character varying(24)` | YES |  | <!-- comment on column public.suppliers.fax is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-suppliers-homepage" href="#public-suppliers-homepage">#</a>`homepage` |  | `text` | YES |  | <!-- comment on column public.suppliers.homepage is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.territories`

<!-- comment on table public.territories is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-territories-territory_id" href="#public-territories-territory_id">#</a>`territory_id` | **PK** | `character varying(20)` | **NO** |  | <!-- comment on column public.territories.territory_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-territories-territory_description" href="#public-territories-territory_description">#</a>`territory_description` |  | `character` | **NO** |  | <!-- comment on column public.territories.territory_description is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-territories-region_id" href="#public-territories-region_id">#</a>`region_id` | **FK [➝](#public-region-region_id) `region.region_id`** | `smallint` | **NO** |  | <!-- comment on column public.territories.region_id is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.us_states`

<!-- comment on table public.us_states is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-us_states-state_id" href="#public-us_states-state_id">#</a>`state_id` | **PK** | `smallint` | **NO** |  | <!-- comment on column public.us_states.state_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-us_states-state_name" href="#public-us_states-state_name">#</a>`state_name` |  | `character varying(100)` | YES |  | <!-- comment on column public.us_states.state_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-us_states-state_abbr" href="#public-us_states-state_abbr">#</a>`state_abbr` |  | `character varying(2)` | YES |  | <!-- comment on column public.us_states.state_abbr is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-us_states-state_region" href="#public-us_states-state_region">#</a>`state_region` |  | `character varying(50)` | YES |  | <!-- comment on column public.us_states.state_region is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

