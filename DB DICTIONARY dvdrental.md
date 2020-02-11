# Dictionary for database `dvdrental`

- Server: PostgreSQL `localhost:5432`, version `10.4`
- Local timestamp: `2020-02-11T19:42:50.0005087+01:00`
- Schemas: `public`

## Table of Contents

- Table [`public.actor`](#table-publicactor)
- Table [`public.address`](#table-publicaddress)
- Table [`public.category`](#table-publiccategory)
- Table [`public.city`](#table-publiccity)
- Table [`public.country`](#table-publiccountry)
- Table [`public.customer`](#table-publiccustomer)
- Table [`public.film`](#table-publicfilm)
- Table [`public.film_actor`](#table-publicfilm_actor)
- Table [`public.film_category`](#table-publicfilm_category)
- Table [`public.inventory`](#table-publicinventory)
- Table [`public.language`](#table-publiclanguage)
- Table [`public.payment`](#table-publicpayment)
- Table [`public.rental`](#table-publicrental)
- Table [`public.staff`](#table-publicstaff)
- Table [`public.store`](#table-publicstore)
- View [`public.actor_info`](#view-publicactor_info)
- View [`public.customer_list`](#view-publiccustomer_list)
- View [`public.film_list`](#view-publicfilm_list)
- View [`public.nicer_but_slower_film_list`](#view-publicnicer_but_slower_film_list)
- View [`public.sales_by_film_category`](#view-publicsales_by_film_category)
- View [`public.sales_by_store`](#view-publicsales_by_store)
- View [`public.staff_list`](#view-publicstaff_list)
- Function [`public._group_concat(text, text)`](#function-public_group_concattext-text)
- Function [`public.film_in_stock(integer, integer, out integer)`](#function-publicfilm_in_stockinteger-integer-out-integer)
- Function [`public.film_not_in_stock(integer, integer, out integer)`](#function-publicfilm_not_in_stockinteger-integer-out-integer)
- Function [`public.get_customer_balance(integer, timestamp without time zone)`](#function-publicget_customer_balanceinteger-timestamp-without-time-zone)
- Function [`public.inventory_held_by_customer(integer)`](#function-publicinventory_held_by_customerinteger)
- Function [`public.inventory_in_stock(integer)`](#function-publicinventory_in_stockinteger)
- Function [`public.last_day(timestamp without time zone)`](#function-publiclast_daytimestamp-without-time-zone)
- Function [`public.last_updated()`](#function-publiclast_updated)
- Function [`public.rewards_report(integer, numeric)`](#function-publicrewards_reportinteger-numeric)
- Function [`public.test()`](#function-publictest)

## Tables

### Table `public.actor`

<!-- comment on table public.actor is @until-end-tag; -->
test comment on actor
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-actor-actor_id" href="#public-actor-actor_id">#</a>`actor_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.actor.actor_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-actor-first_name" href="#public-actor-first_name">#</a>`first_name` |  | `character varying(45)` | **NO** |  | <!-- comment on column public.actor.first_name is @until-end-tag; -->test comment on actor.first_name field<!-- end --> |
| <a id="user-content-public-actor-last_name" href="#public-actor-last_name">#</a>`last_name` | **IDX** | `character varying(45)` | **NO** |  | <!-- comment on column public.actor.last_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-actor-last_update" href="#public-actor-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.actor.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.address`

<!-- comment on table public.address is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-address-address_id" href="#public-address-address_id">#</a>`address_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.address.address_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-address-address" href="#public-address-address">#</a>`address` |  | `character varying(50)` | **NO** |  | <!-- comment on column public.address.address is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-address-address2" href="#public-address-address2">#</a>`address2` |  | `character varying(50)` | YES |  | <!-- comment on column public.address.address2 is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-address-district" href="#public-address-district">#</a>`district` |  | `character varying(20)` | **NO** |  | <!-- comment on column public.address.district is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-address-city_id" href="#public-address-city_id">#</a>`city_id` | **FK [➝](#public-city-city_id) `city.city_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.address.city_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-address-postal_code" href="#public-address-postal_code">#</a>`postal_code` |  | `character varying(10)` | YES |  | <!-- comment on column public.address.postal_code is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-address-phone" href="#public-address-phone">#</a>`phone` |  | `character varying(20)` | **NO** |  | <!-- comment on column public.address.phone is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-address-last_update" href="#public-address-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.address.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.category`

<!-- comment on table public.category is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-category-category_id" href="#public-category-category_id">#</a>`category_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.category.category_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-category-name" href="#public-category-name">#</a>`name` |  | `character varying(25)` | **NO** |  | <!-- comment on column public.category.name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-category-last_update" href="#public-category-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.category.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.city`

<!-- comment on table public.city is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-city-city_id" href="#public-city-city_id">#</a>`city_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.city.city_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-city-city" href="#public-city-city">#</a>`city` |  | `character varying(50)` | **NO** |  | <!-- comment on column public.city.city is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-city-country_id" href="#public-city-country_id">#</a>`country_id` | **FK [➝](#public-country-country_id) `country.country_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.city.country_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-city-last_update" href="#public-city-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.city.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.country`

<!-- comment on table public.country is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-country-country_id" href="#public-country-country_id">#</a>`country_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.country.country_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-country-country" href="#public-country-country">#</a>`country` |  | `character varying(50)` | **NO** |  | <!-- comment on column public.country.country is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-country-last_update" href="#public-country-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.country.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.customer`

<!-- comment on table public.customer is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-customer-customer_id" href="#public-customer-customer_id">#</a>`customer_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.customer.customer_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-store_id" href="#public-customer-store_id">#</a>`store_id` | **IDX** | `smallint` | **NO** |  | <!-- comment on column public.customer.store_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-first_name" href="#public-customer-first_name">#</a>`first_name` |  | `character varying(45)` | **NO** |  | <!-- comment on column public.customer.first_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-last_name" href="#public-customer-last_name">#</a>`last_name` | **IDX** | `character varying(45)` | **NO** |  | <!-- comment on column public.customer.last_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-email" href="#public-customer-email">#</a>`email` |  | `character varying(50)` | YES |  | <!-- comment on column public.customer.email is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-address_id" href="#public-customer-address_id">#</a>`address_id` | **FK [➝](#public-address-address_id) `address.address_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.customer.address_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-activebool" href="#public-customer-activebool">#</a>`activebool` |  | `boolean` | **NO** | `true` | <!-- comment on column public.customer.activebool is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-create_date" href="#public-customer-create_date">#</a>`create_date` |  | `date` | **NO** | `('now'::text)::date` | <!-- comment on column public.customer.create_date is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-last_update" href="#public-customer-last_update">#</a>`last_update` |  | `timestamp without time zone` | YES | `now()` | <!-- comment on column public.customer.last_update is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-customer-active" href="#public-customer-active">#</a>`active` |  | `integer` | YES |  | <!-- comment on column public.customer.active is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.film`

<!-- comment on table public.film is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-film-film_id" href="#public-film-film_id">#</a>`film_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.film.film_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-title" href="#public-film-title">#</a>`title` | **IDX** | `character varying(255)` | **NO** |  | <!-- comment on column public.film.title is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-description" href="#public-film-description">#</a>`description` |  | `text` | YES |  | <!-- comment on column public.film.description is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-release_year" href="#public-film-release_year">#</a>`release_year` |  | `integer` | YES |  | <!-- comment on column public.film.release_year is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-language_id" href="#public-film-language_id">#</a>`language_id` | **FK [➝](#public-language-language_id) `language.language_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.film.language_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-rental_duration" href="#public-film-rental_duration">#</a>`rental_duration` |  | `smallint` | **NO** | `3` | <!-- comment on column public.film.rental_duration is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-rental_rate" href="#public-film-rental_rate">#</a>`rental_rate` |  | `numeric(4,10),2)` | **NO** | `4.99` | <!-- comment on column public.film.rental_rate is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-length" href="#public-film-length">#</a>`length` |  | `smallint` | YES |  | <!-- comment on column public.film.length is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-replacement_cost" href="#public-film-replacement_cost">#</a>`replacement_cost` |  | `numeric(5,10),2)` | **NO** | `19.99` | <!-- comment on column public.film.replacement_cost is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-rating" href="#public-film-rating">#</a>`rating` |  | `USER-DEFINED` | YES | `'G'::mpaa_rating` | <!-- comment on column public.film.rating is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-last_update" href="#public-film-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.film.last_update is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-special_features" href="#public-film-special_features">#</a>`special_features` |  | `ARRAY` | YES |  | <!-- comment on column public.film.special_features is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film-fulltext" href="#public-film-fulltext">#</a>`fulltext` | **IDX** | `tsvector` | **NO** |  | <!-- comment on column public.film.fulltext is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.film_actor`

<!-- comment on table public.film_actor is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-film_actor-actor_id" href="#public-film_actor-actor_id">#</a>`actor_id` | **PK**, **FK [➝](#public-actor-actor_id) `actor.actor_id`** | `smallint` | **NO** |  | <!-- comment on column public.film_actor.actor_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film_actor-film_id" href="#public-film_actor-film_id">#</a>`film_id` | **PK**, **FK [➝](#public-film-film_id) `film.film_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.film_actor.film_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film_actor-last_update" href="#public-film_actor-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.film_actor.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.film_category`

<!-- comment on table public.film_category is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-film_category-film_id" href="#public-film_category-film_id">#</a>`film_id` | **PK**, **FK [➝](#public-film-film_id) `film.film_id`** | `smallint` | **NO** |  | <!-- comment on column public.film_category.film_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film_category-category_id" href="#public-film_category-category_id">#</a>`category_id` | **PK**, **FK [➝](#public-category-category_id) `category.category_id`** | `smallint` | **NO** |  | <!-- comment on column public.film_category.category_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-film_category-last_update" href="#public-film_category-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.film_category.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.inventory`

<!-- comment on table public.inventory is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-inventory-inventory_id" href="#public-inventory-inventory_id">#</a>`inventory_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.inventory.inventory_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-inventory-film_id" href="#public-inventory-film_id">#</a>`film_id` | **FK [➝](#public-film-film_id) `film.film_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.inventory.film_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-inventory-store_id" href="#public-inventory-store_id">#</a>`store_id` | **IDX** | `smallint` | **NO** |  | <!-- comment on column public.inventory.store_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-inventory-last_update" href="#public-inventory-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.inventory.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.language`

<!-- comment on table public.language is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-language-language_id" href="#public-language-language_id">#</a>`language_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.language.language_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-language-name" href="#public-language-name">#</a>`name` |  | `character(20)` | **NO** |  | <!-- comment on column public.language.name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-language-last_update" href="#public-language-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.language.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.payment`

<!-- comment on table public.payment is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-payment-payment_id" href="#public-payment-payment_id">#</a>`payment_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.payment.payment_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-payment-customer_id" href="#public-payment-customer_id">#</a>`customer_id` | **FK [➝](#public-customer-customer_id) `customer.customer_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.payment.customer_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-payment-staff_id" href="#public-payment-staff_id">#</a>`staff_id` | **FK [➝](#public-staff-staff_id) `staff.staff_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.payment.staff_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-payment-rental_id" href="#public-payment-rental_id">#</a>`rental_id` | **FK [➝](#public-rental-rental_id) `rental.rental_id`**, **IDX** | `integer` | **NO** |  | <!-- comment on column public.payment.rental_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-payment-amount" href="#public-payment-amount">#</a>`amount` |  | `numeric(5,10),2)` | **NO** |  | <!-- comment on column public.payment.amount is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-payment-payment_date" href="#public-payment-payment_date">#</a>`payment_date` |  | `timestamp without time zone` | **NO** |  | <!-- comment on column public.payment.payment_date is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.rental`

<!-- comment on table public.rental is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-rental-rental_id" href="#public-rental-rental_id">#</a>`rental_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.rental.rental_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-rental-rental_date" href="#public-rental-rental_date">#</a>`rental_date` | **IDX** | `timestamp without time zone` | **NO** |  | <!-- comment on column public.rental.rental_date is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-rental-inventory_id" href="#public-rental-inventory_id">#</a>`inventory_id` | **FK [➝](#public-inventory-inventory_id) `inventory.inventory_id`**, **IDX**, **IDX** | `integer` | **NO** |  | <!-- comment on column public.rental.inventory_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-rental-customer_id" href="#public-rental-customer_id">#</a>`customer_id` | **FK [➝](#public-customer-customer_id) `customer.customer_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.rental.customer_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-rental-return_date" href="#public-rental-return_date">#</a>`return_date` |  | `timestamp without time zone` | YES |  | <!-- comment on column public.rental.return_date is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-rental-staff_id" href="#public-rental-staff_id">#</a>`staff_id` | **FK [➝](#public-staff-staff_id) `staff.staff_id`** | `smallint` | **NO** |  | <!-- comment on column public.rental.staff_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-rental-last_update" href="#public-rental-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.rental.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.staff`

<!-- comment on table public.staff is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-staff-staff_id" href="#public-staff-staff_id">#</a>`staff_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.staff.staff_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-first_name" href="#public-staff-first_name">#</a>`first_name` |  | `character varying(45)` | **NO** |  | <!-- comment on column public.staff.first_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-last_name" href="#public-staff-last_name">#</a>`last_name` |  | `character varying(45)` | **NO** |  | <!-- comment on column public.staff.last_name is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-address_id" href="#public-staff-address_id">#</a>`address_id` | **FK [➝](#public-address-address_id) `address.address_id`** | `smallint` | **NO** |  | <!-- comment on column public.staff.address_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-email" href="#public-staff-email">#</a>`email` |  | `character varying(50)` | YES |  | <!-- comment on column public.staff.email is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-store_id" href="#public-staff-store_id">#</a>`store_id` |  | `smallint` | **NO** |  | <!-- comment on column public.staff.store_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-active" href="#public-staff-active">#</a>`active` |  | `boolean` | **NO** | `true` | <!-- comment on column public.staff.active is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-username" href="#public-staff-username">#</a>`username` |  | `character varying(16)` | **NO** |  | <!-- comment on column public.staff.username is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-password" href="#public-staff-password">#</a>`password` |  | `character varying(40)` | YES |  | <!-- comment on column public.staff.password is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-last_update" href="#public-staff-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.staff.last_update is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-staff-picture" href="#public-staff-picture">#</a>`picture` |  | `bytea` | YES |  | <!-- comment on column public.staff.picture is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `public.store`

<!-- comment on table public.store is @until-end-tag; -->
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-public-store-store_id" href="#public-store-store_id">#</a>`store_id` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column public.store.store_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-store-manager_staff_id" href="#public-store-manager_staff_id">#</a>`manager_staff_id` | **FK [➝](#public-staff-staff_id) `staff.staff_id`**, **IDX** | `smallint` | **NO** |  | <!-- comment on column public.store.manager_staff_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-store-address_id" href="#public-store-address_id">#</a>`address_id` | **FK [➝](#public-address-address_id) `address.address_id`** | `smallint` | **NO** |  | <!-- comment on column public.store.address_id is @until-end-tag; --><!-- end --> |
| <a id="user-content-public-store-last_update" href="#public-store-last_update">#</a>`last_update` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column public.store.last_update is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `public.actor_info`

<!-- comment on view public.actor_info is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `actor_id` | `integer` | <!-- comment on column public.actor_info.actor_id is @until-end-tag; --><!-- end --> |
| `first_name` | `character varying(45)` | <!-- comment on column public.actor_info.first_name is @until-end-tag; --><!-- end --> |
| `last_name` | `character varying(45)` | <!-- comment on column public.actor_info.last_name is @until-end-tag; --><!-- end --> |
| `film_info` | `text` | <!-- comment on column public.actor_info.film_info is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `public.customer_list`

<!-- comment on view public.customer_list is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column public.customer_list.id is @until-end-tag; --><!-- end --> |
| `name` | `text` | <!-- comment on column public.customer_list.name is @until-end-tag; --><!-- end --> |
| `address` | `character varying(50)` | <!-- comment on column public.customer_list.address is @until-end-tag; --><!-- end --> |
| `zip code` | `character varying(10)` | <!-- comment on column public.customer_list.zip code is @until-end-tag; --><!-- end --> |
| `phone` | `character varying(20)` | <!-- comment on column public.customer_list.phone is @until-end-tag; --><!-- end --> |
| `city` | `character varying(50)` | <!-- comment on column public.customer_list.city is @until-end-tag; --><!-- end --> |
| `country` | `character varying(50)` | <!-- comment on column public.customer_list.country is @until-end-tag; --><!-- end --> |
| `notes` | `text` | <!-- comment on column public.customer_list.notes is @until-end-tag; --><!-- end --> |
| `sid` | `smallint` | <!-- comment on column public.customer_list.sid is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `public.film_list`

<!-- comment on view public.film_list is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `fid` | `integer` | <!-- comment on column public.film_list.fid is @until-end-tag; --><!-- end --> |
| `title` | `character varying(255)` | <!-- comment on column public.film_list.title is @until-end-tag; --><!-- end --> |
| `description` | `text` | <!-- comment on column public.film_list.description is @until-end-tag; --><!-- end --> |
| `category` | `character varying(25)` | <!-- comment on column public.film_list.category is @until-end-tag; --><!-- end --> |
| `price` | `numeric(4,10),2)` | <!-- comment on column public.film_list.price is @until-end-tag; --><!-- end --> |
| `length` | `smallint` | <!-- comment on column public.film_list.length is @until-end-tag; --><!-- end --> |
| `rating` | `USER-DEFINED` | <!-- comment on column public.film_list.rating is @until-end-tag; --><!-- end --> |
| `actors` | `text` | <!-- comment on column public.film_list.actors is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `public.nicer_but_slower_film_list`

<!-- comment on view public.nicer_but_slower_film_list is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `fid` | `integer` | <!-- comment on column public.nicer_but_slower_film_list.fid is @until-end-tag; --><!-- end --> |
| `title` | `character varying(255)` | <!-- comment on column public.nicer_but_slower_film_list.title is @until-end-tag; --><!-- end --> |
| `description` | `text` | <!-- comment on column public.nicer_but_slower_film_list.description is @until-end-tag; --><!-- end --> |
| `category` | `character varying(25)` | <!-- comment on column public.nicer_but_slower_film_list.category is @until-end-tag; --><!-- end --> |
| `price` | `numeric(4,10),2)` | <!-- comment on column public.nicer_but_slower_film_list.price is @until-end-tag; --><!-- end --> |
| `length` | `smallint` | <!-- comment on column public.nicer_but_slower_film_list.length is @until-end-tag; --><!-- end --> |
| `rating` | `USER-DEFINED` | <!-- comment on column public.nicer_but_slower_film_list.rating is @until-end-tag; --><!-- end --> |
| `actors` | `text` | <!-- comment on column public.nicer_but_slower_film_list.actors is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `public.sales_by_film_category`

<!-- comment on view public.sales_by_film_category is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `category` | `character varying(25)` | <!-- comment on column public.sales_by_film_category.category is @until-end-tag; --><!-- end --> |
| `total_sales` | `numeric` | <!-- comment on column public.sales_by_film_category.total_sales is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `public.sales_by_store`

<!-- comment on view public.sales_by_store is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `store` | `text` | <!-- comment on column public.sales_by_store.store is @until-end-tag; --><!-- end --> |
| `manager` | `text` | <!-- comment on column public.sales_by_store.manager is @until-end-tag; --><!-- end --> |
| `total_sales` | `numeric` | <!-- comment on column public.sales_by_store.total_sales is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `public.staff_list`

<!-- comment on view public.staff_list is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column public.staff_list.id is @until-end-tag; --><!-- end --> |
| `name` | `text` | <!-- comment on column public.staff_list.name is @until-end-tag; --><!-- end --> |
| `address` | `character varying(50)` | <!-- comment on column public.staff_list.address is @until-end-tag; --><!-- end --> |
| `zip code` | `character varying(10)` | <!-- comment on column public.staff_list.zip code is @until-end-tag; --><!-- end --> |
| `phone` | `character varying(20)` | <!-- comment on column public.staff_list.phone is @until-end-tag; --><!-- end --> |
| `city` | `character varying(50)` | <!-- comment on column public.staff_list.city is @until-end-tag; --><!-- end --> |
| `country` | `character varying(50)` | <!-- comment on column public.staff_list.country is @until-end-tag; --><!-- end --> |
| `sid` | `smallint` | <!-- comment on column public.staff_list.sid is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

## Routines

### Function `public._group_concat(text, text)`

- Returns `text`

- Language is `sql`

<!-- comment on function public._group_concat(text, text) is @until-end-tag; -->
comment for _group_concat
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.film_in_stock(integer, integer, out integer)`

- Returns `integer`

- Language is `sql`

<!-- comment on function public.film_in_stock(integer, integer, out integer) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.film_not_in_stock(integer, integer, out integer)`

- Returns `integer`

- Language is `sql`

<!-- comment on function public.film_not_in_stock(integer, integer, out integer) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.get_customer_balance(integer, timestamp without time zone)`

- Returns `numeric`

- Language is `plpgsql`

<!-- comment on function public.get_customer_balance(integer, timestamp without time zone) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.inventory_held_by_customer(integer)`

- Returns `integer`

- Language is `plpgsql`

<!-- comment on function public.inventory_held_by_customer(integer) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.inventory_in_stock(integer)`

- Returns `boolean`

- Language is `plpgsql`

<!-- comment on function public.inventory_in_stock(integer) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.last_day(timestamp without time zone)`

- Returns `date`

- Language is `sql`

<!-- comment on function public.last_day(timestamp without time zone) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.last_updated()`

- Returns `trigger`

- Language is `plpgsql`

<!-- comment on function public.last_updated() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.rewards_report(integer, numeric)`

- Returns `setof customer`

- Language is `plpgsql`

<!-- comment on function public.rewards_report(integer, numeric) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.test()`

- Returns `void`

- Language is `plpgsql`

<!-- comment on function public.test() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

