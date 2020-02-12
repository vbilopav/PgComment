# Dictionary for database `Adventureworks`

- Server: PostgreSQL `localhost:5434`, version `12.0`
- Local timestamp: `2020-02-12T12:22:43.4496405+01:00`
- Schemas: `hr`, `humanresources`, `pe`, `person`, `pr`, `production`, `pu`, `public`, `purchasing`, `sa`, `sales`

## Table of Contents

- Table [`humanresources.department`](#table-humanresourcesdepartment)
- Table [`humanresources.employee`](#table-humanresourcesemployee)
- Table [`humanresources.employeedepartmenthistory`](#table-humanresourcesemployeedepartmenthistory)
- Table [`humanresources.employeepayhistory`](#table-humanresourcesemployeepayhistory)
- Table [`humanresources.jobcandidate`](#table-humanresourcesjobcandidate)
- Table [`humanresources.shift`](#table-humanresourcesshift)
- Table [`person.address`](#table-personaddress)
- Table [`person.addresstype`](#table-personaddresstype)
- Table [`person.businessentity`](#table-personbusinessentity)
- Table [`person.businessentityaddress`](#table-personbusinessentityaddress)
- Table [`person.businessentitycontact`](#table-personbusinessentitycontact)
- Table [`person.contacttype`](#table-personcontacttype)
- Table [`person.countryregion`](#table-personcountryregion)
- Table [`person.emailaddress`](#table-personemailaddress)
- Table [`person.password`](#table-personpassword)
- Table [`person.person`](#table-personperson)
- Table [`person.personphone`](#table-personpersonphone)
- Table [`person.phonenumbertype`](#table-personphonenumbertype)
- Table [`person.stateprovince`](#table-personstateprovince)
- Table [`production.billofmaterials`](#table-productionbillofmaterials)
- Table [`production.culture`](#table-productionculture)
- Table [`production.document`](#table-productiondocument)
- Table [`production.illustration`](#table-productionillustration)
- Table [`production.location`](#table-productionlocation)
- Table [`production.product`](#table-productionproduct)
- Table [`production.productcategory`](#table-productionproductcategory)
- Table [`production.productcosthistory`](#table-productionproductcosthistory)
- Table [`production.productdescription`](#table-productionproductdescription)
- Table [`production.productdocument`](#table-productionproductdocument)
- Table [`production.productinventory`](#table-productionproductinventory)
- Table [`production.productlistpricehistory`](#table-productionproductlistpricehistory)
- Table [`production.productmodel`](#table-productionproductmodel)
- Table [`production.productmodelillustration`](#table-productionproductmodelillustration)
- Table [`production.productmodelproductdescriptionculture`](#table-productionproductmodelproductdescriptionculture)
- Table [`production.productphoto`](#table-productionproductphoto)
- Table [`production.productproductphoto`](#table-productionproductproductphoto)
- Table [`production.productreview`](#table-productionproductreview)
- Table [`production.productsubcategory`](#table-productionproductsubcategory)
- Table [`production.scrapreason`](#table-productionscrapreason)
- Table [`production.transactionhistory`](#table-productiontransactionhistory)
- Table [`production.transactionhistoryarchive`](#table-productiontransactionhistoryarchive)
- Table [`production.unitmeasure`](#table-productionunitmeasure)
- Table [`production.workorder`](#table-productionworkorder)
- Table [`production.workorderrouting`](#table-productionworkorderrouting)
- Table [`purchasing.productvendor`](#table-purchasingproductvendor)
- Table [`purchasing.purchaseorderdetail`](#table-purchasingpurchaseorderdetail)
- Table [`purchasing.purchaseorderheader`](#table-purchasingpurchaseorderheader)
- Table [`purchasing.shipmethod`](#table-purchasingshipmethod)
- Table [`purchasing.vendor`](#table-purchasingvendor)
- Table [`sales.countryregioncurrency`](#table-salescountryregioncurrency)
- Table [`sales.creditcard`](#table-salescreditcard)
- Table [`sales.currency`](#table-salescurrency)
- Table [`sales.currencyrate`](#table-salescurrencyrate)
- Table [`sales.customer`](#table-salescustomer)
- Table [`sales.personcreditcard`](#table-salespersoncreditcard)
- Table [`sales.salesorderdetail`](#table-salessalesorderdetail)
- Table [`sales.salesorderheader`](#table-salessalesorderheader)
- Table [`sales.salesorderheadersalesreason`](#table-salessalesorderheadersalesreason)
- Table [`sales.salesperson`](#table-salessalesperson)
- Table [`sales.salespersonquotahistory`](#table-salessalespersonquotahistory)
- Table [`sales.salesreason`](#table-salessalesreason)
- Table [`sales.salestaxrate`](#table-salessalestaxrate)
- Table [`sales.salesterritory`](#table-salessalesterritory)
- Table [`sales.salesterritoryhistory`](#table-salessalesterritoryhistory)
- Table [`sales.shoppingcartitem`](#table-salesshoppingcartitem)
- Table [`sales.specialoffer`](#table-salesspecialoffer)
- Table [`sales.specialofferproduct`](#table-salesspecialofferproduct)
- Table [`sales.store`](#table-salesstore)
- View [`hr.d`](#view-hrd)
- View [`hr.e`](#view-hre)
- View [`hr.edh`](#view-hredh)
- View [`hr.eph`](#view-hreph)
- View [`hr.jc`](#view-hrjc)
- View [`hr.s`](#view-hrs)
- View [`humanresources.vemployee`](#view-humanresourcesvemployee)
- View [`humanresources.vemployeedepartment`](#view-humanresourcesvemployeedepartment)
- View [`humanresources.vemployeedepartmenthistory`](#view-humanresourcesvemployeedepartmenthistory)
- View [`humanresources.vjobcandidate`](#view-humanresourcesvjobcandidate)
- View [`humanresources.vjobcandidateeducation`](#view-humanresourcesvjobcandidateeducation)
- View [`humanresources.vjobcandidateemployment`](#view-humanresourcesvjobcandidateemployment)
- View [`pe.a`](#view-pea)
- View [`pe.at`](#view-peat)
- View [`pe.be`](#view-pebe)
- View [`pe.bea`](#view-pebea)
- View [`pe.bec`](#view-pebec)
- View [`pe.cr`](#view-pecr)
- View [`pe.ct`](#view-pect)
- View [`pe.e`](#view-pee)
- View [`pe.p`](#view-pep)
- View [`pe.pa`](#view-pepa)
- View [`pe.pnt`](#view-pepnt)
- View [`pe.pp`](#view-pepp)
- View [`pe.sp`](#view-pesp)
- View [`person.vadditionalcontactinfo`](#view-personvadditionalcontactinfo)
- View [`pr.bom`](#view-prbom)
- View [`pr.c`](#view-prc)
- View [`pr.d`](#view-prd)
- View [`pr.i`](#view-pri)
- View [`pr.l`](#view-prl)
- View [`pr.p`](#view-prp)
- View [`pr.pc`](#view-prpc)
- View [`pr.pch`](#view-prpch)
- View [`pr.pd`](#view-prpd)
- View [`pr.pdoc`](#view-prpdoc)
- View [`pr.pi`](#view-prpi)
- View [`pr.plph`](#view-prplph)
- View [`pr.pm`](#view-prpm)
- View [`pr.pmi`](#view-prpmi)
- View [`pr.pmpdc`](#view-prpmpdc)
- View [`pr.pp`](#view-prpp)
- View [`pr.ppp`](#view-prppp)
- View [`pr.pr`](#view-prpr)
- View [`pr.psc`](#view-prpsc)
- View [`pr.sr`](#view-prsr)
- View [`pr.th`](#view-prth)
- View [`pr.tha`](#view-prtha)
- View [`pr.um`](#view-prum)
- View [`pr.w`](#view-prw)
- View [`pr.wr`](#view-prwr)
- View [`production.vproductmodelcatalogdescription`](#view-productionvproductmodelcatalogdescription)
- View [`production.vproductmodelinstructions`](#view-productionvproductmodelinstructions)
- View [`pu.pod`](#view-pupod)
- View [`pu.poh`](#view-pupoh)
- View [`pu.pv`](#view-pupv)
- View [`pu.sm`](#view-pusm)
- View [`pu.v`](#view-puv)
- View [`purchasing.vvendorwithaddresses`](#view-purchasingvvendorwithaddresses)
- View [`purchasing.vvendorwithcontacts`](#view-purchasingvvendorwithcontacts)
- View [`sa.c`](#view-sac)
- View [`sa.cc`](#view-sacc)
- View [`sa.cr`](#view-sacr)
- View [`sa.crc`](#view-sacrc)
- View [`sa.cu`](#view-sacu)
- View [`sa.pcc`](#view-sapcc)
- View [`sa.s`](#view-sas)
- View [`sa.sci`](#view-sasci)
- View [`sa.so`](#view-saso)
- View [`sa.sod`](#view-sasod)
- View [`sa.soh`](#view-sasoh)
- View [`sa.sohsr`](#view-sasohsr)
- View [`sa.sop`](#view-sasop)
- View [`sa.sp`](#view-sasp)
- View [`sa.spqh`](#view-saspqh)
- View [`sa.sr`](#view-sasr)
- View [`sa.st`](#view-sast)
- View [`sa.sth`](#view-sasth)
- View [`sa.tr`](#view-satr)
- View [`sales.vindividualcustomer`](#view-salesvindividualcustomer)
- View [`sales.vpersondemographics`](#view-salesvpersondemographics)
- View [`sales.vsalesperson`](#view-salesvsalesperson)
- View [`sales.vsalespersonsalesbyfiscalyears`](#view-salesvsalespersonsalesbyfiscalyears)
- View [`sales.vsalespersonsalesbyfiscalyearsdata`](#view-salesvsalespersonsalesbyfiscalyearsdata)
- View [`sales.vstorewithaddresses`](#view-salesvstorewithaddresses)
- View [`sales.vstorewithcontacts`](#view-salesvstorewithcontacts)
- View [`sales.vstorewithdemographics`](#view-salesvstorewithdemographics)
- Function [`public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer, text, text, text, text)`](#function-publicconnectbytext-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-integer-integer-integer-integer-text-text-text-text)
- Function [`public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer)`](#function-publicconnectbytext-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-integer-integer-integer-integer)
- Function [`public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer, text, text, text, text)`](#function-publicconnectbytext-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-integer-integer-integer-integer-text-text-text-text)
- Function [`public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer)`](#function-publicconnectbytext-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-text-integer-integer-integer-integer)
- Function [`public.crosstab2(text)`](#function-publiccrosstab2text)
- Function [`public.crosstab3(text)`](#function-publiccrosstab3text)
- Function [`public.crosstab4(text)`](#function-publiccrosstab4text)
- Function [`public.crosstab(text, text, text)`](#function-publiccrosstabtext-text-text)
- Function [`public.crosstab(text, text, text, integer, integer, integer)`](#function-publiccrosstabtext-text-text-integer-integer-integer)
- Function [`public.crosstab(text, text, text, text, text, text)`](#function-publiccrosstabtext-text-text-text-text-text)
- Function [`public.normal_rand(integer, double precision, double precision)`](#function-publicnormal_randinteger-double-precision-double-precision)
- Function [`public.uuid_generate_v1()`](#function-publicuuid_generate_v1)
- Function [`public.uuid_generate_v1mc()`](#function-publicuuid_generate_v1mc)
- Function [`public.uuid_generate_v3(uuid, text)`](#function-publicuuid_generate_v3uuid-text)
- Function [`public.uuid_generate_v4()`](#function-publicuuid_generate_v4)
- Function [`public.uuid_generate_v5(uuid, text)`](#function-publicuuid_generate_v5uuid-text)
- Function [`public.uuid_nil()`](#function-publicuuid_nil)
- Function [`public.uuid_ns_dns()`](#function-publicuuid_ns_dns)
- Function [`public.uuid_ns_oid()`](#function-publicuuid_ns_oid)
- Function [`public.uuid_ns_url()`](#function-publicuuid_ns_url)
- Function [`public.uuid_ns_x500()`](#function-publicuuid_ns_x500)

## Tables

### Table `humanresources.department`

<!-- comment on table humanresources.department is @until-end-tag; -->
Lookup table containing the departments within the Adventure Works Cycles company.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-humanresources-department-departmentid" href="#humanresources-department-departmentid">#</a>`departmentid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column humanresources.department.departmentid is @until-end-tag; -->Primary key for Department records.<!-- end --> |
| <a id="user-content-humanresources-department-name" href="#humanresources-department-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column humanresources.department.name is @until-end-tag; -->Name of the department.<!-- end --> |
| <a id="user-content-humanresources-department-groupname" href="#humanresources-department-groupname">#</a>`groupname` |  | `character varying(50)` | **NO** |  | <!-- comment on column humanresources.department.groupname is @until-end-tag; -->Name of the group to which the department belongs.<!-- end --> |
| <a id="user-content-humanresources-department-modifieddate" href="#humanresources-department-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column humanresources.department.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `humanresources.employee`

<!-- comment on table humanresources.employee is @until-end-tag; -->
Employee information such as salary, department, and title.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-humanresources-employee-businessentityid" href="#humanresources-employee-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-person-businessentityid) `person.person.businessentityid`** | `integer` | **NO** |  | <!-- comment on column humanresources.employee.businessentityid is @until-end-tag; -->Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.<!-- end --> |
| <a id="user-content-humanresources-employee-nationalidnumber" href="#humanresources-employee-nationalidnumber">#</a>`nationalidnumber` |  | `character varying(15)` | **NO** |  | <!-- comment on column humanresources.employee.nationalidnumber is @until-end-tag; -->Unique national identification number such as a social security number.<!-- end --> |
| <a id="user-content-humanresources-employee-loginid" href="#humanresources-employee-loginid">#</a>`loginid` |  | `character varying(256)` | **NO** |  | <!-- comment on column humanresources.employee.loginid is @until-end-tag; -->Network login.<!-- end --> |
| <a id="user-content-humanresources-employee-jobtitle" href="#humanresources-employee-jobtitle">#</a>`jobtitle` |  | `character varying(50)` | **NO** |  | <!-- comment on column humanresources.employee.jobtitle is @until-end-tag; -->Work title such as Buyer or Sales Representative.<!-- end --> |
| <a id="user-content-humanresources-employee-birthdate" href="#humanresources-employee-birthdate">#</a>`birthdate` | CHECK | `date` | **NO** |  | <!-- comment on column humanresources.employee.birthdate is @until-end-tag; -->Date of birth.<!-- end --> |
| <a id="user-content-humanresources-employee-maritalstatus" href="#humanresources-employee-maritalstatus">#</a>`maritalstatus` | CHECK | `character(1)` | **NO** |  | <!-- comment on column humanresources.employee.maritalstatus is @until-end-tag; -->M = Married, S = Single<!-- end --> |
| <a id="user-content-humanresources-employee-gender" href="#humanresources-employee-gender">#</a>`gender` | CHECK | `character(1)` | **NO** |  | <!-- comment on column humanresources.employee.gender is @until-end-tag; -->M = Male, F = Female<!-- end --> |
| <a id="user-content-humanresources-employee-hiredate" href="#humanresources-employee-hiredate">#</a>`hiredate` | CHECK | `date` | **NO** |  | <!-- comment on column humanresources.employee.hiredate is @until-end-tag; -->Employee hired on this date.<!-- end --> |
| <a id="user-content-humanresources-employee-salariedflag" href="#humanresources-employee-salariedflag">#</a>`salariedflag` |  | `boolean` | **NO** | `true` | <!-- comment on column humanresources.employee.salariedflag is @until-end-tag; -->Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.<!-- end --> |
| <a id="user-content-humanresources-employee-vacationhours" href="#humanresources-employee-vacationhours">#</a>`vacationhours` | CHECK | `smallint` | **NO** | `0` | <!-- comment on column humanresources.employee.vacationhours is @until-end-tag; -->Number of available vacation hours.<!-- end --> |
| <a id="user-content-humanresources-employee-sickleavehours" href="#humanresources-employee-sickleavehours">#</a>`sickleavehours` | CHECK | `smallint` | **NO** | `0` | <!-- comment on column humanresources.employee.sickleavehours is @until-end-tag; -->Number of available sick leave hours.<!-- end --> |
| <a id="user-content-humanresources-employee-currentflag" href="#humanresources-employee-currentflag">#</a>`currentflag` |  | `boolean` | **NO** | `true` | <!-- comment on column humanresources.employee.currentflag is @until-end-tag; -->0 = Inactive, 1 = Active<!-- end --> |
| <a id="user-content-humanresources-employee-rowguid" href="#humanresources-employee-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column humanresources.employee.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-humanresources-employee-modifieddate" href="#humanresources-employee-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column humanresources.employee.modifieddate is @until-end-tag; --><!-- end --> |
| <a id="user-content-humanresources-employee-organizationnode" href="#humanresources-employee-organizationnode">#</a>`organizationnode` |  | `character varying` | YES | `'/'::character varying` | <!-- comment on column humanresources.employee.organizationnode is @until-end-tag; -->Where the employee is located in corporate hierarchy.<!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `humanresources.employeedepartmenthistory`

<!-- comment on table humanresources.employeedepartmenthistory is @until-end-tag; -->
Employee department transfers.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-humanresources-employeedepartmenthistory-businessentityid" href="#humanresources-employeedepartmenthistory-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#humanresources-employee-businessentityid) `employee.businessentityid`** | `integer` | **NO** |  | <!-- comment on column humanresources.employeedepartmenthistory.businessentityid is @until-end-tag; -->Employee identification number. Foreign key to Employee.BusinessEntityID.<!-- end --> |
| <a id="user-content-humanresources-employeedepartmenthistory-departmentid" href="#humanresources-employeedepartmenthistory-departmentid">#</a>`departmentid` | **PK**, **FK [➝](#humanresources-department-departmentid) `department.departmentid`** | `smallint` | **NO** |  | <!-- comment on column humanresources.employeedepartmenthistory.departmentid is @until-end-tag; -->Department in which the employee worked including currently. Foreign key to Department.DepartmentID.<!-- end --> |
| <a id="user-content-humanresources-employeedepartmenthistory-shiftid" href="#humanresources-employeedepartmenthistory-shiftid">#</a>`shiftid` | **PK**, **FK [➝](#humanresources-shift-shiftid) `shift.shiftid`** | `smallint` | **NO** |  | <!-- comment on column humanresources.employeedepartmenthistory.shiftid is @until-end-tag; -->Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.<!-- end --> |
| <a id="user-content-humanresources-employeedepartmenthistory-startdate" href="#humanresources-employeedepartmenthistory-startdate">#</a>`startdate` | **PK**, CHECK | `date` | **NO** |  | <!-- comment on column humanresources.employeedepartmenthistory.startdate is @until-end-tag; -->Date the employee started work in the department.<!-- end --> |
| <a id="user-content-humanresources-employeedepartmenthistory-enddate" href="#humanresources-employeedepartmenthistory-enddate">#</a>`enddate` | CHECK | `date` | YES |  | <!-- comment on column humanresources.employeedepartmenthistory.enddate is @until-end-tag; -->Date the employee left the department. NULL = Current department.<!-- end --> |
| <a id="user-content-humanresources-employeedepartmenthistory-modifieddate" href="#humanresources-employeedepartmenthistory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column humanresources.employeedepartmenthistory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `humanresources.employeepayhistory`

<!-- comment on table humanresources.employeepayhistory is @until-end-tag; -->
Employee pay history.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-humanresources-employeepayhistory-businessentityid" href="#humanresources-employeepayhistory-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#humanresources-employee-businessentityid) `employee.businessentityid`** | `integer` | **NO** |  | <!-- comment on column humanresources.employeepayhistory.businessentityid is @until-end-tag; -->Employee identification number. Foreign key to Employee.BusinessEntityID.<!-- end --> |
| <a id="user-content-humanresources-employeepayhistory-ratechangedate" href="#humanresources-employeepayhistory-ratechangedate">#</a>`ratechangedate` | **PK** | `timestamp without time zone` | **NO** |  | <!-- comment on column humanresources.employeepayhistory.ratechangedate is @until-end-tag; -->Date the change in pay is effective<!-- end --> |
| <a id="user-content-humanresources-employeepayhistory-rate" href="#humanresources-employeepayhistory-rate">#</a>`rate` | CHECK | `numeric` | **NO** |  | <!-- comment on column humanresources.employeepayhistory.rate is @until-end-tag; -->Salary hourly rate.<!-- end --> |
| <a id="user-content-humanresources-employeepayhistory-payfrequency" href="#humanresources-employeepayhistory-payfrequency">#</a>`payfrequency` | CHECK | `smallint` | **NO** |  | <!-- comment on column humanresources.employeepayhistory.payfrequency is @until-end-tag; -->1 = Salary received monthly, 2 = Salary received biweekly<!-- end --> |
| <a id="user-content-humanresources-employeepayhistory-modifieddate" href="#humanresources-employeepayhistory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column humanresources.employeepayhistory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `humanresources.jobcandidate`

<!-- comment on table humanresources.jobcandidate is @until-end-tag; -->
Résumés submitted to Human Resources by job applicants.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-humanresources-jobcandidate-jobcandidateid" href="#humanresources-jobcandidate-jobcandidateid">#</a>`jobcandidateid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column humanresources.jobcandidate.jobcandidateid is @until-end-tag; -->Primary key for JobCandidate records.<!-- end --> |
| <a id="user-content-humanresources-jobcandidate-businessentityid" href="#humanresources-jobcandidate-businessentityid">#</a>`businessentityid` | **FK [➝](#humanresources-employee-businessentityid) `employee.businessentityid`** | `integer` | YES |  | <!-- comment on column humanresources.jobcandidate.businessentityid is @until-end-tag; -->Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.<!-- end --> |
| <a id="user-content-humanresources-jobcandidate-resume" href="#humanresources-jobcandidate-resume">#</a>`resume` |  | `xml` | YES |  | <!-- comment on column humanresources.jobcandidate.resume is @until-end-tag; -->Résumé in XML format.<!-- end --> |
| <a id="user-content-humanresources-jobcandidate-modifieddate" href="#humanresources-jobcandidate-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column humanresources.jobcandidate.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `humanresources.shift`

<!-- comment on table humanresources.shift is @until-end-tag; -->
Work shift lookup table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-humanresources-shift-shiftid" href="#humanresources-shift-shiftid">#</a>`shiftid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column humanresources.shift.shiftid is @until-end-tag; -->Primary key for Shift records.<!-- end --> |
| <a id="user-content-humanresources-shift-name" href="#humanresources-shift-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column humanresources.shift.name is @until-end-tag; -->Shift description.<!-- end --> |
| <a id="user-content-humanresources-shift-starttime" href="#humanresources-shift-starttime">#</a>`starttime` |  | `time without time zone` | **NO** |  | <!-- comment on column humanresources.shift.starttime is @until-end-tag; -->Shift start time.<!-- end --> |
| <a id="user-content-humanresources-shift-endtime" href="#humanresources-shift-endtime">#</a>`endtime` |  | `time without time zone` | **NO** |  | <!-- comment on column humanresources.shift.endtime is @until-end-tag; -->Shift end time.<!-- end --> |
| <a id="user-content-humanresources-shift-modifieddate" href="#humanresources-shift-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column humanresources.shift.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.address`

<!-- comment on table person.address is @until-end-tag; -->
Street address information for customers, employees, and vendors.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-address-addressid" href="#person-address-addressid">#</a>`addressid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column person.address.addressid is @until-end-tag; -->Primary key for Address records.<!-- end --> |
| <a id="user-content-person-address-addressline1" href="#person-address-addressline1">#</a>`addressline1` |  | `character varying(60)` | **NO** |  | <!-- comment on column person.address.addressline1 is @until-end-tag; -->First street address line.<!-- end --> |
| <a id="user-content-person-address-addressline2" href="#person-address-addressline2">#</a>`addressline2` |  | `character varying(60)` | YES |  | <!-- comment on column person.address.addressline2 is @until-end-tag; -->Second street address line.<!-- end --> |
| <a id="user-content-person-address-city" href="#person-address-city">#</a>`city` |  | `character varying(30)` | **NO** |  | <!-- comment on column person.address.city is @until-end-tag; -->Name of the city.<!-- end --> |
| <a id="user-content-person-address-stateprovinceid" href="#person-address-stateprovinceid">#</a>`stateprovinceid` | **FK [➝](#person-stateprovince-stateprovinceid) `stateprovince.stateprovinceid`** | `integer` | **NO** |  | <!-- comment on column person.address.stateprovinceid is @until-end-tag; -->Unique identification number for the state or province. Foreign key to StateProvince table.<!-- end --> |
| <a id="user-content-person-address-postalcode" href="#person-address-postalcode">#</a>`postalcode` |  | `character varying(15)` | **NO** |  | <!-- comment on column person.address.postalcode is @until-end-tag; -->Postal code for the street address.<!-- end --> |
| <a id="user-content-person-address-spatiallocation" href="#person-address-spatiallocation">#</a>`spatiallocation` |  | `character varying(44)` | YES |  | <!-- comment on column person.address.spatiallocation is @until-end-tag; -->Latitude and longitude of this address.<!-- end --> |
| <a id="user-content-person-address-rowguid" href="#person-address-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.address.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-address-modifieddate" href="#person-address-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.address.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.addresstype`

<!-- comment on table person.addresstype is @until-end-tag; -->
Types of addresses stored in the Address table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-addresstype-addresstypeid" href="#person-addresstype-addresstypeid">#</a>`addresstypeid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column person.addresstype.addresstypeid is @until-end-tag; -->Primary key for AddressType records.<!-- end --> |
| <a id="user-content-person-addresstype-name" href="#person-addresstype-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column person.addresstype.name is @until-end-tag; -->Address type description. For example, Billing, Home, or Shipping.<!-- end --> |
| <a id="user-content-person-addresstype-rowguid" href="#person-addresstype-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.addresstype.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-addresstype-modifieddate" href="#person-addresstype-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.addresstype.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.businessentity`

<!-- comment on table person.businessentity is @until-end-tag; -->
Source of the ID that connects vendors, customers, and employees with address and contact information.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-businessentity-businessentityid" href="#person-businessentity-businessentityid">#</a>`businessentityid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column person.businessentity.businessentityid is @until-end-tag; -->Primary key for all customers, vendors, and employees.<!-- end --> |
| <a id="user-content-person-businessentity-rowguid" href="#person-businessentity-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.businessentity.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-businessentity-modifieddate" href="#person-businessentity-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.businessentity.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.businessentityaddress`

<!-- comment on table person.businessentityaddress is @until-end-tag; -->
Cross-reference table mapping customers, vendors, and employees to their addresses.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-businessentityaddress-businessentityid" href="#person-businessentityaddress-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-businessentity-businessentityid) `businessentity.businessentityid`** | `integer` | **NO** |  | <!-- comment on column person.businessentityaddress.businessentityid is @until-end-tag; -->Primary key. Foreign key to BusinessEntity.BusinessEntityID.<!-- end --> |
| <a id="user-content-person-businessentityaddress-addressid" href="#person-businessentityaddress-addressid">#</a>`addressid` | **PK**, **FK [➝](#person-address-addressid) `address.addressid`** | `integer` | **NO** |  | <!-- comment on column person.businessentityaddress.addressid is @until-end-tag; -->Primary key. Foreign key to Address.AddressID.<!-- end --> |
| <a id="user-content-person-businessentityaddress-addresstypeid" href="#person-businessentityaddress-addresstypeid">#</a>`addresstypeid` | **PK**, **FK [➝](#person-addresstype-addresstypeid) `addresstype.addresstypeid`** | `integer` | **NO** |  | <!-- comment on column person.businessentityaddress.addresstypeid is @until-end-tag; -->Primary key. Foreign key to AddressType.AddressTypeID.<!-- end --> |
| <a id="user-content-person-businessentityaddress-rowguid" href="#person-businessentityaddress-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.businessentityaddress.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-businessentityaddress-modifieddate" href="#person-businessentityaddress-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.businessentityaddress.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.businessentitycontact`

<!-- comment on table person.businessentitycontact is @until-end-tag; -->
Cross-reference table mapping stores, vendors, and employees to people
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-businessentitycontact-businessentityid" href="#person-businessentitycontact-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-businessentity-businessentityid) `businessentity.businessentityid`** | `integer` | **NO** |  | <!-- comment on column person.businessentitycontact.businessentityid is @until-end-tag; -->Primary key. Foreign key to BusinessEntity.BusinessEntityID.<!-- end --> |
| <a id="user-content-person-businessentitycontact-personid" href="#person-businessentitycontact-personid">#</a>`personid` | **PK**, **FK [➝](#person-person-businessentityid) `person.businessentityid`** | `integer` | **NO** |  | <!-- comment on column person.businessentitycontact.personid is @until-end-tag; -->Primary key. Foreign key to Person.BusinessEntityID.<!-- end --> |
| <a id="user-content-person-businessentitycontact-contacttypeid" href="#person-businessentitycontact-contacttypeid">#</a>`contacttypeid` | **PK**, **FK [➝](#person-contacttype-contacttypeid) `contacttype.contacttypeid`** | `integer` | **NO** |  | <!-- comment on column person.businessentitycontact.contacttypeid is @until-end-tag; -->Primary key.  Foreign key to ContactType.ContactTypeID.<!-- end --> |
| <a id="user-content-person-businessentitycontact-rowguid" href="#person-businessentitycontact-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.businessentitycontact.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-businessentitycontact-modifieddate" href="#person-businessentitycontact-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.businessentitycontact.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.contacttype`

<!-- comment on table person.contacttype is @until-end-tag; -->
Lookup table containing the types of business entity contacts.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-contacttype-contacttypeid" href="#person-contacttype-contacttypeid">#</a>`contacttypeid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column person.contacttype.contacttypeid is @until-end-tag; -->Primary key for ContactType records.<!-- end --> |
| <a id="user-content-person-contacttype-name" href="#person-contacttype-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column person.contacttype.name is @until-end-tag; -->Contact type description.<!-- end --> |
| <a id="user-content-person-contacttype-modifieddate" href="#person-contacttype-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.contacttype.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.countryregion`

<!-- comment on table person.countryregion is @until-end-tag; -->
Lookup table containing the ISO standard codes for countries and regions.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-countryregion-countryregioncode" href="#person-countryregion-countryregioncode">#</a>`countryregioncode` | **PK** | `character varying(3)` | **NO** |  | <!-- comment on column person.countryregion.countryregioncode is @until-end-tag; -->ISO standard code for countries and regions.<!-- end --> |
| <a id="user-content-person-countryregion-name" href="#person-countryregion-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column person.countryregion.name is @until-end-tag; -->Country or region name.<!-- end --> |
| <a id="user-content-person-countryregion-modifieddate" href="#person-countryregion-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.countryregion.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.emailaddress`

<!-- comment on table person.emailaddress is @until-end-tag; -->
Where to send a person email.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-emailaddress-businessentityid" href="#person-emailaddress-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-person-businessentityid) `person.businessentityid`** | `integer` | **NO** |  | <!-- comment on column person.emailaddress.businessentityid is @until-end-tag; -->Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID<!-- end --> |
| <a id="user-content-person-emailaddress-emailaddressid" href="#person-emailaddress-emailaddressid">#</a>`emailaddressid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column person.emailaddress.emailaddressid is @until-end-tag; -->Primary key. ID of this email address.<!-- end --> |
| <a id="user-content-person-emailaddress-emailaddress" href="#person-emailaddress-emailaddress">#</a>`emailaddress` |  | `character varying(50)` | YES |  | <!-- comment on column person.emailaddress.emailaddress is @until-end-tag; -->E-mail address for the person.<!-- end --> |
| <a id="user-content-person-emailaddress-rowguid" href="#person-emailaddress-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.emailaddress.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-emailaddress-modifieddate" href="#person-emailaddress-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.emailaddress.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.password`

<!-- comment on table person.password is @until-end-tag; -->
One way hashed authentication information
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-password-businessentityid" href="#person-password-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-person-businessentityid) `person.businessentityid`** | `integer` | **NO** |  | <!-- comment on column person.password.businessentityid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-password-passwordhash" href="#person-password-passwordhash">#</a>`passwordhash` |  | `character varying(128)` | **NO** |  | <!-- comment on column person.password.passwordhash is @until-end-tag; -->Password for the e-mail account.<!-- end --> |
| <a id="user-content-person-password-passwordsalt" href="#person-password-passwordsalt">#</a>`passwordsalt` |  | `character varying(10)` | **NO** |  | <!-- comment on column person.password.passwordsalt is @until-end-tag; -->Random value concatenated with the password string before the password is hashed.<!-- end --> |
| <a id="user-content-person-password-rowguid" href="#person-password-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.password.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-password-modifieddate" href="#person-password-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.password.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.person`

<!-- comment on table person.person is @until-end-tag; -->
Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-person-businessentityid" href="#person-person-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-businessentity-businessentityid) `businessentity.businessentityid`** | `integer` | **NO** |  | <!-- comment on column person.person.businessentityid is @until-end-tag; -->Primary key for Person records.<!-- end --> |
| <a id="user-content-person-person-persontype" href="#person-person-persontype">#</a>`persontype` | CHECK | `character(2)` | **NO** |  | <!-- comment on column person.person.persontype is @until-end-tag; -->Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact<!-- end --> |
| <a id="user-content-person-person-namestyle" href="#person-person-namestyle">#</a>`namestyle` |  | `boolean` | **NO** | `false` | <!-- comment on column person.person.namestyle is @until-end-tag; -->0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.<!-- end --> |
| <a id="user-content-person-person-title" href="#person-person-title">#</a>`title` |  | `character varying(8)` | YES |  | <!-- comment on column person.person.title is @until-end-tag; -->A courtesy title. For example, Mr. or Ms.<!-- end --> |
| <a id="user-content-person-person-firstname" href="#person-person-firstname">#</a>`firstname` |  | `character varying(50)` | **NO** |  | <!-- comment on column person.person.firstname is @until-end-tag; -->First name of the person.<!-- end --> |
| <a id="user-content-person-person-middlename" href="#person-person-middlename">#</a>`middlename` |  | `character varying(50)` | YES |  | <!-- comment on column person.person.middlename is @until-end-tag; -->Middle name or middle initial of the person.<!-- end --> |
| <a id="user-content-person-person-lastname" href="#person-person-lastname">#</a>`lastname` |  | `character varying(50)` | **NO** |  | <!-- comment on column person.person.lastname is @until-end-tag; -->Last name of the person.<!-- end --> |
| <a id="user-content-person-person-suffix" href="#person-person-suffix">#</a>`suffix` |  | `character varying(10)` | YES |  | <!-- comment on column person.person.suffix is @until-end-tag; -->Surname suffix. For example, Sr. or Jr.<!-- end --> |
| <a id="user-content-person-person-emailpromotion" href="#person-person-emailpromotion">#</a>`emailpromotion` | CHECK | `integer` | **NO** | `0` | <!-- comment on column person.person.emailpromotion is @until-end-tag; -->0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.<!-- end --> |
| <a id="user-content-person-person-additionalcontactinfo" href="#person-person-additionalcontactinfo">#</a>`additionalcontactinfo` |  | `xml` | YES |  | <!-- comment on column person.person.additionalcontactinfo is @until-end-tag; -->Additional contact information about the person stored in xml format.<!-- end --> |
| <a id="user-content-person-person-demographics" href="#person-person-demographics">#</a>`demographics` |  | `xml` | YES |  | <!-- comment on column person.person.demographics is @until-end-tag; -->Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.<!-- end --> |
| <a id="user-content-person-person-rowguid" href="#person-person-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.person.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-person-modifieddate" href="#person-person-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.person.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.personphone`

<!-- comment on table person.personphone is @until-end-tag; -->
Telephone number and type of a person.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-personphone-businessentityid" href="#person-personphone-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-person-businessentityid) `person.businessentityid`** | `integer` | **NO** |  | <!-- comment on column person.personphone.businessentityid is @until-end-tag; -->Business entity identification number. Foreign key to Person.BusinessEntityID.<!-- end --> |
| <a id="user-content-person-personphone-phonenumber" href="#person-personphone-phonenumber">#</a>`phonenumber` | **PK** | `character varying(25)` | **NO** |  | <!-- comment on column person.personphone.phonenumber is @until-end-tag; -->Telephone number identification number.<!-- end --> |
| <a id="user-content-person-personphone-phonenumbertypeid" href="#person-personphone-phonenumbertypeid">#</a>`phonenumbertypeid` | **PK**, **FK [➝](#person-phonenumbertype-phonenumbertypeid) `phonenumbertype.phonenumbertypeid`** | `integer` | **NO** |  | <!-- comment on column person.personphone.phonenumbertypeid is @until-end-tag; -->Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.<!-- end --> |
| <a id="user-content-person-personphone-modifieddate" href="#person-personphone-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.personphone.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.phonenumbertype`

<!-- comment on table person.phonenumbertype is @until-end-tag; -->
Type of phone number of a person.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-phonenumbertype-phonenumbertypeid" href="#person-phonenumbertype-phonenumbertypeid">#</a>`phonenumbertypeid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column person.phonenumbertype.phonenumbertypeid is @until-end-tag; -->Primary key for telephone number type records.<!-- end --> |
| <a id="user-content-person-phonenumbertype-name" href="#person-phonenumbertype-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column person.phonenumbertype.name is @until-end-tag; -->Name of the telephone number type<!-- end --> |
| <a id="user-content-person-phonenumbertype-modifieddate" href="#person-phonenumbertype-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.phonenumbertype.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `person.stateprovince`

<!-- comment on table person.stateprovince is @until-end-tag; -->
State and province lookup table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-person-stateprovince-stateprovinceid" href="#person-stateprovince-stateprovinceid">#</a>`stateprovinceid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column person.stateprovince.stateprovinceid is @until-end-tag; -->Primary key for StateProvince records.<!-- end --> |
| <a id="user-content-person-stateprovince-stateprovincecode" href="#person-stateprovince-stateprovincecode">#</a>`stateprovincecode` |  | `character(3)` | **NO** |  | <!-- comment on column person.stateprovince.stateprovincecode is @until-end-tag; -->ISO standard state or province code.<!-- end --> |
| <a id="user-content-person-stateprovince-countryregioncode" href="#person-stateprovince-countryregioncode">#</a>`countryregioncode` | **FK [➝](#person-countryregion-countryregioncode) `countryregion.countryregioncode`** | `character varying(3)` | **NO** |  | <!-- comment on column person.stateprovince.countryregioncode is @until-end-tag; -->ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.<!-- end --> |
| <a id="user-content-person-stateprovince-isonlystateprovinceflag" href="#person-stateprovince-isonlystateprovinceflag">#</a>`isonlystateprovinceflag` |  | `boolean` | **NO** | `true` | <!-- comment on column person.stateprovince.isonlystateprovinceflag is @until-end-tag; -->0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.<!-- end --> |
| <a id="user-content-person-stateprovince-name" href="#person-stateprovince-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column person.stateprovince.name is @until-end-tag; -->State or province description.<!-- end --> |
| <a id="user-content-person-stateprovince-territoryid" href="#person-stateprovince-territoryid">#</a>`territoryid` | **FK [➝](#sales-salesterritory-territoryid) `sales.salesterritory.territoryid`** | `integer` | **NO** |  | <!-- comment on column person.stateprovince.territoryid is @until-end-tag; -->ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.<!-- end --> |
| <a id="user-content-person-stateprovince-rowguid" href="#person-stateprovince-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column person.stateprovince.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-person-stateprovince-modifieddate" href="#person-stateprovince-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column person.stateprovince.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.billofmaterials`

<!-- comment on table production.billofmaterials is @until-end-tag; -->
Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-billofmaterials-billofmaterialsid" href="#production-billofmaterials-billofmaterialsid">#</a>`billofmaterialsid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.billofmaterials.billofmaterialsid is @until-end-tag; -->Primary key for BillOfMaterials records.<!-- end --> |
| <a id="user-content-production-billofmaterials-productassemblyid" href="#production-billofmaterials-productassemblyid">#</a>`productassemblyid` | **FK [➝](#production-product-productid) `product.productid`**, CHECK, CHECK | `integer` | YES |  | <!-- comment on column production.billofmaterials.productassemblyid is @until-end-tag; -->Parent product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-billofmaterials-componentid" href="#production-billofmaterials-componentid">#</a>`componentid` | **FK [➝](#production-product-productid) `product.productid`**, CHECK | `integer` | **NO** |  | <!-- comment on column production.billofmaterials.componentid is @until-end-tag; -->Component identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-billofmaterials-startdate" href="#production-billofmaterials-startdate">#</a>`startdate` | CHECK | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.billofmaterials.startdate is @until-end-tag; -->Date the component started being used in the assembly item.<!-- end --> |
| <a id="user-content-production-billofmaterials-enddate" href="#production-billofmaterials-enddate">#</a>`enddate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column production.billofmaterials.enddate is @until-end-tag; -->Date the component stopped being used in the assembly item.<!-- end --> |
| <a id="user-content-production-billofmaterials-unitmeasurecode" href="#production-billofmaterials-unitmeasurecode">#</a>`unitmeasurecode` | **FK [➝](#production-unitmeasure-unitmeasurecode) `unitmeasure.unitmeasurecode`** | `character(3)` | **NO** |  | <!-- comment on column production.billofmaterials.unitmeasurecode is @until-end-tag; -->Standard code identifying the unit of measure for the quantity.<!-- end --> |
| <a id="user-content-production-billofmaterials-bomlevel" href="#production-billofmaterials-bomlevel">#</a>`bomlevel` | CHECK | `smallint` | **NO** |  | <!-- comment on column production.billofmaterials.bomlevel is @until-end-tag; -->Indicates the depth the component is from its parent (AssemblyID).<!-- end --> |
| <a id="user-content-production-billofmaterials-perassemblyqty" href="#production-billofmaterials-perassemblyqty">#</a>`perassemblyqty` | CHECK, CHECK | `numeric(8,10),2)` | **NO** | `1.00` | <!-- comment on column production.billofmaterials.perassemblyqty is @until-end-tag; -->Quantity of the component needed to create the assembly.<!-- end --> |
| <a id="user-content-production-billofmaterials-modifieddate" href="#production-billofmaterials-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.billofmaterials.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.culture`

<!-- comment on table production.culture is @until-end-tag; -->
Lookup table containing the languages in which some AdventureWorks data is stored.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-culture-cultureid" href="#production-culture-cultureid">#</a>`cultureid` | **PK** | `character(6)` | **NO** |  | <!-- comment on column production.culture.cultureid is @until-end-tag; -->Primary key for Culture records.<!-- end --> |
| <a id="user-content-production-culture-name" href="#production-culture-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.culture.name is @until-end-tag; -->Culture description.<!-- end --> |
| <a id="user-content-production-culture-modifieddate" href="#production-culture-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.culture.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.document`

<!-- comment on table production.document is @until-end-tag; -->
Product maintenance documents.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-document-title" href="#production-document-title">#</a>`title` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.document.title is @until-end-tag; -->Title of the document.<!-- end --> |
| <a id="user-content-production-document-owner" href="#production-document-owner">#</a>`owner` | **FK [➝](#humanresources-employee-businessentityid) `humanresources.employee.businessentityid`** | `integer` | **NO** |  | <!-- comment on column production.document.owner is @until-end-tag; -->Employee who controls the document.  Foreign key to Employee.BusinessEntityID<!-- end --> |
| <a id="user-content-production-document-folderflag" href="#production-document-folderflag">#</a>`folderflag` |  | `boolean` | **NO** | `false` | <!-- comment on column production.document.folderflag is @until-end-tag; -->0 = This is a folder, 1 = This is a document.<!-- end --> |
| <a id="user-content-production-document-filename" href="#production-document-filename">#</a>`filename` |  | `character varying(400)` | **NO** |  | <!-- comment on column production.document.filename is @until-end-tag; -->File name of the document<!-- end --> |
| <a id="user-content-production-document-fileextension" href="#production-document-fileextension">#</a>`fileextension` |  | `character varying(8)` | YES |  | <!-- comment on column production.document.fileextension is @until-end-tag; -->File extension indicating the document type. For example, .doc or .txt.<!-- end --> |
| <a id="user-content-production-document-revision" href="#production-document-revision">#</a>`revision` |  | `character(5)` | **NO** |  | <!-- comment on column production.document.revision is @until-end-tag; -->Revision number of the document.<!-- end --> |
| <a id="user-content-production-document-changenumber" href="#production-document-changenumber">#</a>`changenumber` |  | `integer` | **NO** | `0` | <!-- comment on column production.document.changenumber is @until-end-tag; -->Engineering change approval number.<!-- end --> |
| <a id="user-content-production-document-status" href="#production-document-status">#</a>`status` | CHECK | `smallint` | **NO** |  | <!-- comment on column production.document.status is @until-end-tag; -->1 = Pending approval, 2 = Approved, 3 = Obsolete<!-- end --> |
| <a id="user-content-production-document-documentsummary" href="#production-document-documentsummary">#</a>`documentsummary` |  | `text` | YES |  | <!-- comment on column production.document.documentsummary is @until-end-tag; -->Document abstract.<!-- end --> |
| <a id="user-content-production-document-document" href="#production-document-document">#</a>`document` |  | `bytea` | YES |  | <!-- comment on column production.document.document is @until-end-tag; -->Complete document.<!-- end --> |
| <a id="user-content-production-document-rowguid" href="#production-document-rowguid">#</a>`rowguid` | UNIQUE | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column production.document.rowguid is @until-end-tag; -->ROWGUIDCOL number uniquely identifying the record. Required for FileStream.<!-- end --> |
| <a id="user-content-production-document-modifieddate" href="#production-document-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.document.modifieddate is @until-end-tag; --><!-- end --> |
| <a id="user-content-production-document-documentnode" href="#production-document-documentnode">#</a>`documentnode` | **PK** | `character varying` | **NO** | `'/'::character varying` | <!-- comment on column production.document.documentnode is @until-end-tag; -->Primary key for Document records.<!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.illustration`

<!-- comment on table production.illustration is @until-end-tag; -->
Bicycle assembly diagrams.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-illustration-illustrationid" href="#production-illustration-illustrationid">#</a>`illustrationid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.illustration.illustrationid is @until-end-tag; -->Primary key for Illustration records.<!-- end --> |
| <a id="user-content-production-illustration-diagram" href="#production-illustration-diagram">#</a>`diagram` |  | `xml` | YES |  | <!-- comment on column production.illustration.diagram is @until-end-tag; -->Illustrations used in manufacturing instructions. Stored as XML.<!-- end --> |
| <a id="user-content-production-illustration-modifieddate" href="#production-illustration-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.illustration.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.location`

<!-- comment on table production.location is @until-end-tag; -->
Product inventory and manufacturing locations.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-location-locationid" href="#production-location-locationid">#</a>`locationid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.location.locationid is @until-end-tag; -->Primary key for Location records.<!-- end --> |
| <a id="user-content-production-location-name" href="#production-location-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.location.name is @until-end-tag; -->Location description.<!-- end --> |
| <a id="user-content-production-location-costrate" href="#production-location-costrate">#</a>`costrate` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column production.location.costrate is @until-end-tag; -->Standard hourly cost of the manufacturing location.<!-- end --> |
| <a id="user-content-production-location-availability" href="#production-location-availability">#</a>`availability` | CHECK | `numeric(8,10),2)` | **NO** | `0.00` | <!-- comment on column production.location.availability is @until-end-tag; -->Work capacity (in hours) of the manufacturing location.<!-- end --> |
| <a id="user-content-production-location-modifieddate" href="#production-location-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.location.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.product`

<!-- comment on table production.product is @until-end-tag; -->
Products sold or used in the manfacturing of sold products.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-product-productid" href="#production-product-productid">#</a>`productid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.product.productid is @until-end-tag; -->Primary key for Product records.<!-- end --> |
| <a id="user-content-production-product-name" href="#production-product-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.product.name is @until-end-tag; -->Name of the product.<!-- end --> |
| <a id="user-content-production-product-productnumber" href="#production-product-productnumber">#</a>`productnumber` |  | `character varying(25)` | **NO** |  | <!-- comment on column production.product.productnumber is @until-end-tag; -->Unique product identification number.<!-- end --> |
| <a id="user-content-production-product-makeflag" href="#production-product-makeflag">#</a>`makeflag` |  | `boolean` | **NO** | `true` | <!-- comment on column production.product.makeflag is @until-end-tag; -->0 = Product is purchased, 1 = Product is manufactured in-house.<!-- end --> |
| <a id="user-content-production-product-finishedgoodsflag" href="#production-product-finishedgoodsflag">#</a>`finishedgoodsflag` |  | `boolean` | **NO** | `true` | <!-- comment on column production.product.finishedgoodsflag is @until-end-tag; -->0 = Product is not a salable item. 1 = Product is salable.<!-- end --> |
| <a id="user-content-production-product-color" href="#production-product-color">#</a>`color` |  | `character varying(15)` | YES |  | <!-- comment on column production.product.color is @until-end-tag; -->Product color.<!-- end --> |
| <a id="user-content-production-product-safetystocklevel" href="#production-product-safetystocklevel">#</a>`safetystocklevel` | CHECK | `smallint` | **NO** |  | <!-- comment on column production.product.safetystocklevel is @until-end-tag; -->Minimum inventory quantity.<!-- end --> |
| <a id="user-content-production-product-reorderpoint" href="#production-product-reorderpoint">#</a>`reorderpoint` | CHECK | `smallint` | **NO** |  | <!-- comment on column production.product.reorderpoint is @until-end-tag; -->Inventory level that triggers a purchase order or work order.<!-- end --> |
| <a id="user-content-production-product-standardcost" href="#production-product-standardcost">#</a>`standardcost` | CHECK | `numeric` | **NO** |  | <!-- comment on column production.product.standardcost is @until-end-tag; -->Standard cost of the product.<!-- end --> |
| <a id="user-content-production-product-listprice" href="#production-product-listprice">#</a>`listprice` | CHECK | `numeric` | **NO** |  | <!-- comment on column production.product.listprice is @until-end-tag; -->Selling price.<!-- end --> |
| <a id="user-content-production-product-size" href="#production-product-size">#</a>`size` |  | `character varying(5)` | YES |  | <!-- comment on column production.product.size is @until-end-tag; -->Product size.<!-- end --> |
| <a id="user-content-production-product-sizeunitmeasurecode" href="#production-product-sizeunitmeasurecode">#</a>`sizeunitmeasurecode` | **FK [➝](#production-unitmeasure-unitmeasurecode) `unitmeasure.unitmeasurecode`** | `character(3)` | YES |  | <!-- comment on column production.product.sizeunitmeasurecode is @until-end-tag; -->Unit of measure for Size column.<!-- end --> |
| <a id="user-content-production-product-weightunitmeasurecode" href="#production-product-weightunitmeasurecode">#</a>`weightunitmeasurecode` | **FK [➝](#production-unitmeasure-unitmeasurecode) `unitmeasure.unitmeasurecode`** | `character(3)` | YES |  | <!-- comment on column production.product.weightunitmeasurecode is @until-end-tag; -->Unit of measure for Weight column.<!-- end --> |
| <a id="user-content-production-product-weight" href="#production-product-weight">#</a>`weight` | CHECK | `numeric(8,10),2)` | YES |  | <!-- comment on column production.product.weight is @until-end-tag; -->Product weight.<!-- end --> |
| <a id="user-content-production-product-daystomanufacture" href="#production-product-daystomanufacture">#</a>`daystomanufacture` | CHECK | `integer` | **NO** |  | <!-- comment on column production.product.daystomanufacture is @until-end-tag; -->Number of days required to manufacture the product.<!-- end --> |
| <a id="user-content-production-product-productline" href="#production-product-productline">#</a>`productline` | CHECK | `character(2)` | YES |  | <!-- comment on column production.product.productline is @until-end-tag; -->R = Road, M = Mountain, T = Touring, S = Standard<!-- end --> |
| <a id="user-content-production-product-class" href="#production-product-class">#</a>`class` | CHECK | `character(2)` | YES |  | <!-- comment on column production.product.class is @until-end-tag; -->H = High, M = Medium, L = Low<!-- end --> |
| <a id="user-content-production-product-style" href="#production-product-style">#</a>`style` | CHECK | `character(2)` | YES |  | <!-- comment on column production.product.style is @until-end-tag; -->W = Womens, M = Mens, U = Universal<!-- end --> |
| <a id="user-content-production-product-productsubcategoryid" href="#production-product-productsubcategoryid">#</a>`productsubcategoryid` | **FK [➝](#production-productsubcategory-productsubcategoryid) `productsubcategory.productsubcategoryid`** | `integer` | YES |  | <!-- comment on column production.product.productsubcategoryid is @until-end-tag; -->Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID.<!-- end --> |
| <a id="user-content-production-product-productmodelid" href="#production-product-productmodelid">#</a>`productmodelid` | **FK [➝](#production-productmodel-productmodelid) `productmodel.productmodelid`** | `integer` | YES |  | <!-- comment on column production.product.productmodelid is @until-end-tag; -->Product is a member of this product model. Foreign key to ProductModel.ProductModelID.<!-- end --> |
| <a id="user-content-production-product-sellstartdate" href="#production-product-sellstartdate">#</a>`sellstartdate` | CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column production.product.sellstartdate is @until-end-tag; -->Date the product was available for sale.<!-- end --> |
| <a id="user-content-production-product-sellenddate" href="#production-product-sellenddate">#</a>`sellenddate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column production.product.sellenddate is @until-end-tag; -->Date the product was no longer available for sale.<!-- end --> |
| <a id="user-content-production-product-discontinueddate" href="#production-product-discontinueddate">#</a>`discontinueddate` |  | `timestamp without time zone` | YES |  | <!-- comment on column production.product.discontinueddate is @until-end-tag; -->Date the product was discontinued.<!-- end --> |
| <a id="user-content-production-product-rowguid" href="#production-product-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column production.product.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-production-product-modifieddate" href="#production-product-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.product.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productcategory`

<!-- comment on table production.productcategory is @until-end-tag; -->
High-level product categorization.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productcategory-productcategoryid" href="#production-productcategory-productcategoryid">#</a>`productcategoryid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.productcategory.productcategoryid is @until-end-tag; -->Primary key for ProductCategory records.<!-- end --> |
| <a id="user-content-production-productcategory-name" href="#production-productcategory-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.productcategory.name is @until-end-tag; -->Category description.<!-- end --> |
| <a id="user-content-production-productcategory-rowguid" href="#production-productcategory-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column production.productcategory.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-production-productcategory-modifieddate" href="#production-productcategory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productcategory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productcosthistory`

<!-- comment on table production.productcosthistory is @until-end-tag; -->
Changes in the cost of a product over time.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productcosthistory-productid" href="#production-productcosthistory-productid">#</a>`productid` | **PK**, **FK [➝](#production-product-productid) `product.productid`** | `integer` | **NO** |  | <!-- comment on column production.productcosthistory.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID<!-- end --> |
| <a id="user-content-production-productcosthistory-startdate" href="#production-productcosthistory-startdate">#</a>`startdate` | **PK**, CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column production.productcosthistory.startdate is @until-end-tag; -->Product cost start date.<!-- end --> |
| <a id="user-content-production-productcosthistory-enddate" href="#production-productcosthistory-enddate">#</a>`enddate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column production.productcosthistory.enddate is @until-end-tag; -->Product cost end date.<!-- end --> |
| <a id="user-content-production-productcosthistory-standardcost" href="#production-productcosthistory-standardcost">#</a>`standardcost` | CHECK | `numeric` | **NO** |  | <!-- comment on column production.productcosthistory.standardcost is @until-end-tag; -->Standard cost of the product.<!-- end --> |
| <a id="user-content-production-productcosthistory-modifieddate" href="#production-productcosthistory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productcosthistory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productdescription`

<!-- comment on table production.productdescription is @until-end-tag; -->
Product descriptions in several languages.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productdescription-productdescriptionid" href="#production-productdescription-productdescriptionid">#</a>`productdescriptionid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.productdescription.productdescriptionid is @until-end-tag; -->Primary key for ProductDescription records.<!-- end --> |
| <a id="user-content-production-productdescription-description" href="#production-productdescription-description">#</a>`description` |  | `character varying(400)` | **NO** |  | <!-- comment on column production.productdescription.description is @until-end-tag; -->Description of the product.<!-- end --> |
| <a id="user-content-production-productdescription-rowguid" href="#production-productdescription-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column production.productdescription.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-production-productdescription-modifieddate" href="#production-productdescription-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productdescription.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productdocument`

<!-- comment on table production.productdocument is @until-end-tag; -->
Cross-reference table mapping products to related product documents.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productdocument-productid" href="#production-productdocument-productid">#</a>`productid` | **PK**, **FK [➝](#production-product-productid) `product.productid`** | `integer` | **NO** |  | <!-- comment on column production.productdocument.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-productdocument-modifieddate" href="#production-productdocument-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productdocument.modifieddate is @until-end-tag; --><!-- end --> |
| <a id="user-content-production-productdocument-documentnode" href="#production-productdocument-documentnode">#</a>`documentnode` | **PK**, **FK [➝](#production-document-documentnode) `document.documentnode`** | `character varying` | **NO** | `'/'::character varying` | <!-- comment on column production.productdocument.documentnode is @until-end-tag; -->Document identification number. Foreign key to Document.DocumentNode.<!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productinventory`

<!-- comment on table production.productinventory is @until-end-tag; -->
Product inventory information.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productinventory-productid" href="#production-productinventory-productid">#</a>`productid` | **PK**, **FK [➝](#production-product-productid) `product.productid`** | `integer` | **NO** |  | <!-- comment on column production.productinventory.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-productinventory-locationid" href="#production-productinventory-locationid">#</a>`locationid` | **PK**, **FK [➝](#production-location-locationid) `location.locationid`** | `smallint` | **NO** |  | <!-- comment on column production.productinventory.locationid is @until-end-tag; -->Inventory location identification number. Foreign key to Location.LocationID.<!-- end --> |
| <a id="user-content-production-productinventory-shelf" href="#production-productinventory-shelf">#</a>`shelf` |  | `character varying(10)` | **NO** |  | <!-- comment on column production.productinventory.shelf is @until-end-tag; -->Storage compartment within an inventory location.<!-- end --> |
| <a id="user-content-production-productinventory-bin" href="#production-productinventory-bin">#</a>`bin` | CHECK | `smallint` | **NO** |  | <!-- comment on column production.productinventory.bin is @until-end-tag; -->Storage container on a shelf in an inventory location.<!-- end --> |
| <a id="user-content-production-productinventory-quantity" href="#production-productinventory-quantity">#</a>`quantity` |  | `smallint` | **NO** | `0` | <!-- comment on column production.productinventory.quantity is @until-end-tag; -->Quantity of products in the inventory location.<!-- end --> |
| <a id="user-content-production-productinventory-rowguid" href="#production-productinventory-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column production.productinventory.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-production-productinventory-modifieddate" href="#production-productinventory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productinventory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productlistpricehistory`

<!-- comment on table production.productlistpricehistory is @until-end-tag; -->
Changes in the list price of a product over time.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productlistpricehistory-productid" href="#production-productlistpricehistory-productid">#</a>`productid` | **PK**, **FK [➝](#production-product-productid) `product.productid`** | `integer` | **NO** |  | <!-- comment on column production.productlistpricehistory.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID<!-- end --> |
| <a id="user-content-production-productlistpricehistory-startdate" href="#production-productlistpricehistory-startdate">#</a>`startdate` | **PK**, CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column production.productlistpricehistory.startdate is @until-end-tag; -->List price start date.<!-- end --> |
| <a id="user-content-production-productlistpricehistory-enddate" href="#production-productlistpricehistory-enddate">#</a>`enddate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column production.productlistpricehistory.enddate is @until-end-tag; -->List price end date<!-- end --> |
| <a id="user-content-production-productlistpricehistory-listprice" href="#production-productlistpricehistory-listprice">#</a>`listprice` | CHECK | `numeric` | **NO** |  | <!-- comment on column production.productlistpricehistory.listprice is @until-end-tag; -->Product list price.<!-- end --> |
| <a id="user-content-production-productlistpricehistory-modifieddate" href="#production-productlistpricehistory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productlistpricehistory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productmodel`

<!-- comment on table production.productmodel is @until-end-tag; -->
Product model classification.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productmodel-productmodelid" href="#production-productmodel-productmodelid">#</a>`productmodelid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.productmodel.productmodelid is @until-end-tag; -->Primary key for ProductModel records.<!-- end --> |
| <a id="user-content-production-productmodel-name" href="#production-productmodel-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.productmodel.name is @until-end-tag; -->Product model description.<!-- end --> |
| <a id="user-content-production-productmodel-catalogdescription" href="#production-productmodel-catalogdescription">#</a>`catalogdescription` |  | `xml` | YES |  | <!-- comment on column production.productmodel.catalogdescription is @until-end-tag; -->Detailed product catalog information in xml format.<!-- end --> |
| <a id="user-content-production-productmodel-instructions" href="#production-productmodel-instructions">#</a>`instructions` |  | `xml` | YES |  | <!-- comment on column production.productmodel.instructions is @until-end-tag; -->Manufacturing instructions in xml format.<!-- end --> |
| <a id="user-content-production-productmodel-rowguid" href="#production-productmodel-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column production.productmodel.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-production-productmodel-modifieddate" href="#production-productmodel-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productmodel.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productmodelillustration`

<!-- comment on table production.productmodelillustration is @until-end-tag; -->
Cross-reference table mapping product models and illustrations.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productmodelillustration-productmodelid" href="#production-productmodelillustration-productmodelid">#</a>`productmodelid` | **PK**, **FK [➝](#production-productmodel-productmodelid) `productmodel.productmodelid`** | `integer` | **NO** |  | <!-- comment on column production.productmodelillustration.productmodelid is @until-end-tag; -->Primary key. Foreign key to ProductModel.ProductModelID.<!-- end --> |
| <a id="user-content-production-productmodelillustration-illustrationid" href="#production-productmodelillustration-illustrationid">#</a>`illustrationid` | **PK**, **FK [➝](#production-illustration-illustrationid) `illustration.illustrationid`** | `integer` | **NO** |  | <!-- comment on column production.productmodelillustration.illustrationid is @until-end-tag; -->Primary key. Foreign key to Illustration.IllustrationID.<!-- end --> |
| <a id="user-content-production-productmodelillustration-modifieddate" href="#production-productmodelillustration-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productmodelillustration.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productmodelproductdescriptionculture`

<!-- comment on table production.productmodelproductdescriptionculture is @until-end-tag; -->
Cross-reference table mapping product descriptions and the language the description is written in.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productmodelproductdescriptionculture-productmodelid" href="#production-productmodelproductdescriptionculture-productmodelid">#</a>`productmodelid` | **PK**, **FK [➝](#production-productmodel-productmodelid) `productmodel.productmodelid`** | `integer` | **NO** |  | <!-- comment on column production.productmodelproductdescriptionculture.productmodelid is @until-end-tag; -->Primary key. Foreign key to ProductModel.ProductModelID.<!-- end --> |
| <a id="user-content-production-productmodelproductdescriptionculture-productdescriptionid" href="#production-productmodelproductdescriptionculture-productdescriptionid">#</a>`productdescriptionid` | **PK**, **FK [➝](#production-productdescription-productdescriptionid) `productdescription.productdescriptionid`** | `integer` | **NO** |  | <!-- comment on column production.productmodelproductdescriptionculture.productdescriptionid is @until-end-tag; -->Primary key. Foreign key to ProductDescription.ProductDescriptionID.<!-- end --> |
| <a id="user-content-production-productmodelproductdescriptionculture-cultureid" href="#production-productmodelproductdescriptionculture-cultureid">#</a>`cultureid` | **PK**, **FK [➝](#production-culture-cultureid) `culture.cultureid`** | `character(6)` | **NO** |  | <!-- comment on column production.productmodelproductdescriptionculture.cultureid is @until-end-tag; -->Culture identification number. Foreign key to Culture.CultureID.<!-- end --> |
| <a id="user-content-production-productmodelproductdescriptionculture-modifieddate" href="#production-productmodelproductdescriptionculture-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productmodelproductdescriptionculture.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productphoto`

<!-- comment on table production.productphoto is @until-end-tag; -->
Product images.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productphoto-productphotoid" href="#production-productphoto-productphotoid">#</a>`productphotoid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.productphoto.productphotoid is @until-end-tag; -->Primary key for ProductPhoto records.<!-- end --> |
| <a id="user-content-production-productphoto-thumbnailphoto" href="#production-productphoto-thumbnailphoto">#</a>`thumbnailphoto` |  | `bytea` | YES |  | <!-- comment on column production.productphoto.thumbnailphoto is @until-end-tag; -->Small image of the product.<!-- end --> |
| <a id="user-content-production-productphoto-thumbnailphotofilename" href="#production-productphoto-thumbnailphotofilename">#</a>`thumbnailphotofilename` |  | `character varying(50)` | YES |  | <!-- comment on column production.productphoto.thumbnailphotofilename is @until-end-tag; -->Small image file name.<!-- end --> |
| <a id="user-content-production-productphoto-largephoto" href="#production-productphoto-largephoto">#</a>`largephoto` |  | `bytea` | YES |  | <!-- comment on column production.productphoto.largephoto is @until-end-tag; -->Large image of the product.<!-- end --> |
| <a id="user-content-production-productphoto-largephotofilename" href="#production-productphoto-largephotofilename">#</a>`largephotofilename` |  | `character varying(50)` | YES |  | <!-- comment on column production.productphoto.largephotofilename is @until-end-tag; -->Large image file name.<!-- end --> |
| <a id="user-content-production-productphoto-modifieddate" href="#production-productphoto-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productphoto.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productproductphoto`

<!-- comment on table production.productproductphoto is @until-end-tag; -->
Cross-reference table mapping products and product photos.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productproductphoto-productid" href="#production-productproductphoto-productid">#</a>`productid` | **PK**, **FK [➝](#production-product-productid) `product.productid`** | `integer` | **NO** |  | <!-- comment on column production.productproductphoto.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-productproductphoto-productphotoid" href="#production-productproductphoto-productphotoid">#</a>`productphotoid` | **PK**, **FK [➝](#production-productphoto-productphotoid) `productphoto.productphotoid`** | `integer` | **NO** |  | <!-- comment on column production.productproductphoto.productphotoid is @until-end-tag; -->Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.<!-- end --> |
| <a id="user-content-production-productproductphoto-primary" href="#production-productproductphoto-primary">#</a>`primary` |  | `boolean` | **NO** | `false` | <!-- comment on column production.productproductphoto.primary is @until-end-tag; -->0 = Photo is not the principal image. 1 = Photo is the principal image.<!-- end --> |
| <a id="user-content-production-productproductphoto-modifieddate" href="#production-productproductphoto-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productproductphoto.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productreview`

<!-- comment on table production.productreview is @until-end-tag; -->
Customer reviews of products they have purchased.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productreview-productreviewid" href="#production-productreview-productreviewid">#</a>`productreviewid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.productreview.productreviewid is @until-end-tag; -->Primary key for ProductReview records.<!-- end --> |
| <a id="user-content-production-productreview-productid" href="#production-productreview-productid">#</a>`productid` | **FK [➝](#production-product-productid) `product.productid`** | `integer` | **NO** |  | <!-- comment on column production.productreview.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-productreview-reviewername" href="#production-productreview-reviewername">#</a>`reviewername` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.productreview.reviewername is @until-end-tag; -->Name of the reviewer.<!-- end --> |
| <a id="user-content-production-productreview-reviewdate" href="#production-productreview-reviewdate">#</a>`reviewdate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productreview.reviewdate is @until-end-tag; -->Date review was submitted.<!-- end --> |
| <a id="user-content-production-productreview-emailaddress" href="#production-productreview-emailaddress">#</a>`emailaddress` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.productreview.emailaddress is @until-end-tag; -->Reviewer's e-mail address.<!-- end --> |
| <a id="user-content-production-productreview-rating" href="#production-productreview-rating">#</a>`rating` | CHECK | `integer` | **NO** |  | <!-- comment on column production.productreview.rating is @until-end-tag; -->Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.<!-- end --> |
| <a id="user-content-production-productreview-comments" href="#production-productreview-comments">#</a>`comments` |  | `character varying(3850)` | YES |  | <!-- comment on column production.productreview.comments is @until-end-tag; -->Reviewer's comments<!-- end --> |
| <a id="user-content-production-productreview-modifieddate" href="#production-productreview-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productreview.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.productsubcategory`

<!-- comment on table production.productsubcategory is @until-end-tag; -->
Product subcategories. See ProductCategory table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-productsubcategory-productsubcategoryid" href="#production-productsubcategory-productsubcategoryid">#</a>`productsubcategoryid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.productsubcategory.productsubcategoryid is @until-end-tag; -->Primary key for ProductSubcategory records.<!-- end --> |
| <a id="user-content-production-productsubcategory-productcategoryid" href="#production-productsubcategory-productcategoryid">#</a>`productcategoryid` | **FK [➝](#production-productcategory-productcategoryid) `productcategory.productcategoryid`** | `integer` | **NO** |  | <!-- comment on column production.productsubcategory.productcategoryid is @until-end-tag; -->Product category identification number. Foreign key to ProductCategory.ProductCategoryID.<!-- end --> |
| <a id="user-content-production-productsubcategory-name" href="#production-productsubcategory-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.productsubcategory.name is @until-end-tag; -->Subcategory description.<!-- end --> |
| <a id="user-content-production-productsubcategory-rowguid" href="#production-productsubcategory-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column production.productsubcategory.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-production-productsubcategory-modifieddate" href="#production-productsubcategory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.productsubcategory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.scrapreason`

<!-- comment on table production.scrapreason is @until-end-tag; -->
Manufacturing failure reasons lookup table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-scrapreason-scrapreasonid" href="#production-scrapreason-scrapreasonid">#</a>`scrapreasonid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.scrapreason.scrapreasonid is @until-end-tag; -->Primary key for ScrapReason records.<!-- end --> |
| <a id="user-content-production-scrapreason-name" href="#production-scrapreason-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.scrapreason.name is @until-end-tag; -->Failure description.<!-- end --> |
| <a id="user-content-production-scrapreason-modifieddate" href="#production-scrapreason-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.scrapreason.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.transactionhistory`

<!-- comment on table production.transactionhistory is @until-end-tag; -->
Record of each purchase order, sales order, or work order transaction year to date.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-transactionhistory-transactionid" href="#production-transactionhistory-transactionid">#</a>`transactionid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.transactionhistory.transactionid is @until-end-tag; -->Primary key for TransactionHistory records.<!-- end --> |
| <a id="user-content-production-transactionhistory-productid" href="#production-transactionhistory-productid">#</a>`productid` | **FK [➝](#production-product-productid) `product.productid`** | `integer` | **NO** |  | <!-- comment on column production.transactionhistory.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-transactionhistory-referenceorderid" href="#production-transactionhistory-referenceorderid">#</a>`referenceorderid` |  | `integer` | **NO** |  | <!-- comment on column production.transactionhistory.referenceorderid is @until-end-tag; -->Purchase order, sales order, or work order identification number.<!-- end --> |
| <a id="user-content-production-transactionhistory-referenceorderlineid" href="#production-transactionhistory-referenceorderlineid">#</a>`referenceorderlineid` |  | `integer` | **NO** | `0` | <!-- comment on column production.transactionhistory.referenceorderlineid is @until-end-tag; -->Line number associated with the purchase order, sales order, or work order.<!-- end --> |
| <a id="user-content-production-transactionhistory-transactiondate" href="#production-transactionhistory-transactiondate">#</a>`transactiondate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.transactionhistory.transactiondate is @until-end-tag; -->Date and time of the transaction.<!-- end --> |
| <a id="user-content-production-transactionhistory-transactiontype" href="#production-transactionhistory-transactiontype">#</a>`transactiontype` | CHECK | `character(1)` | **NO** |  | <!-- comment on column production.transactionhistory.transactiontype is @until-end-tag; -->W = WorkOrder, S = SalesOrder, P = PurchaseOrder<!-- end --> |
| <a id="user-content-production-transactionhistory-quantity" href="#production-transactionhistory-quantity">#</a>`quantity` |  | `integer` | **NO** |  | <!-- comment on column production.transactionhistory.quantity is @until-end-tag; -->Product quantity.<!-- end --> |
| <a id="user-content-production-transactionhistory-actualcost" href="#production-transactionhistory-actualcost">#</a>`actualcost` |  | `numeric` | **NO** |  | <!-- comment on column production.transactionhistory.actualcost is @until-end-tag; -->Product cost.<!-- end --> |
| <a id="user-content-production-transactionhistory-modifieddate" href="#production-transactionhistory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.transactionhistory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.transactionhistoryarchive`

<!-- comment on table production.transactionhistoryarchive is @until-end-tag; -->
Transactions for previous years.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-transactionhistoryarchive-transactionid" href="#production-transactionhistoryarchive-transactionid">#</a>`transactionid` | **PK** | `integer` | **NO** |  | <!-- comment on column production.transactionhistoryarchive.transactionid is @until-end-tag; -->Primary key for TransactionHistoryArchive records.<!-- end --> |
| <a id="user-content-production-transactionhistoryarchive-productid" href="#production-transactionhistoryarchive-productid">#</a>`productid` |  | `integer` | **NO** |  | <!-- comment on column production.transactionhistoryarchive.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-transactionhistoryarchive-referenceorderid" href="#production-transactionhistoryarchive-referenceorderid">#</a>`referenceorderid` |  | `integer` | **NO** |  | <!-- comment on column production.transactionhistoryarchive.referenceorderid is @until-end-tag; -->Purchase order, sales order, or work order identification number.<!-- end --> |
| <a id="user-content-production-transactionhistoryarchive-referenceorderlineid" href="#production-transactionhistoryarchive-referenceorderlineid">#</a>`referenceorderlineid` |  | `integer` | **NO** | `0` | <!-- comment on column production.transactionhistoryarchive.referenceorderlineid is @until-end-tag; -->Line number associated with the purchase order, sales order, or work order.<!-- end --> |
| <a id="user-content-production-transactionhistoryarchive-transactiondate" href="#production-transactionhistoryarchive-transactiondate">#</a>`transactiondate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.transactionhistoryarchive.transactiondate is @until-end-tag; -->Date and time of the transaction.<!-- end --> |
| <a id="user-content-production-transactionhistoryarchive-transactiontype" href="#production-transactionhistoryarchive-transactiontype">#</a>`transactiontype` | CHECK | `character(1)` | **NO** |  | <!-- comment on column production.transactionhistoryarchive.transactiontype is @until-end-tag; -->W = Work Order, S = Sales Order, P = Purchase Order<!-- end --> |
| <a id="user-content-production-transactionhistoryarchive-quantity" href="#production-transactionhistoryarchive-quantity">#</a>`quantity` |  | `integer` | **NO** |  | <!-- comment on column production.transactionhistoryarchive.quantity is @until-end-tag; -->Product quantity.<!-- end --> |
| <a id="user-content-production-transactionhistoryarchive-actualcost" href="#production-transactionhistoryarchive-actualcost">#</a>`actualcost` |  | `numeric` | **NO** |  | <!-- comment on column production.transactionhistoryarchive.actualcost is @until-end-tag; -->Product cost.<!-- end --> |
| <a id="user-content-production-transactionhistoryarchive-modifieddate" href="#production-transactionhistoryarchive-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.transactionhistoryarchive.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.unitmeasure`

<!-- comment on table production.unitmeasure is @until-end-tag; -->
Unit of measure lookup table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-unitmeasure-unitmeasurecode" href="#production-unitmeasure-unitmeasurecode">#</a>`unitmeasurecode` | **PK** | `character(3)` | **NO** |  | <!-- comment on column production.unitmeasure.unitmeasurecode is @until-end-tag; -->Primary key.<!-- end --> |
| <a id="user-content-production-unitmeasure-name" href="#production-unitmeasure-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column production.unitmeasure.name is @until-end-tag; -->Unit of measure description.<!-- end --> |
| <a id="user-content-production-unitmeasure-modifieddate" href="#production-unitmeasure-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.unitmeasure.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.workorder`

<!-- comment on table production.workorder is @until-end-tag; -->
Manufacturing work orders.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-workorder-workorderid" href="#production-workorder-workorderid">#</a>`workorderid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column production.workorder.workorderid is @until-end-tag; -->Primary key for WorkOrder records.<!-- end --> |
| <a id="user-content-production-workorder-productid" href="#production-workorder-productid">#</a>`productid` | **FK [➝](#production-product-productid) `product.productid`** | `integer` | **NO** |  | <!-- comment on column production.workorder.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-workorder-orderqty" href="#production-workorder-orderqty">#</a>`orderqty` | CHECK | `integer` | **NO** |  | <!-- comment on column production.workorder.orderqty is @until-end-tag; -->Product quantity to build.<!-- end --> |
| <a id="user-content-production-workorder-scrappedqty" href="#production-workorder-scrappedqty">#</a>`scrappedqty` | CHECK | `smallint` | **NO** |  | <!-- comment on column production.workorder.scrappedqty is @until-end-tag; -->Quantity that failed inspection.<!-- end --> |
| <a id="user-content-production-workorder-startdate" href="#production-workorder-startdate">#</a>`startdate` | CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column production.workorder.startdate is @until-end-tag; -->Work order start date.<!-- end --> |
| <a id="user-content-production-workorder-enddate" href="#production-workorder-enddate">#</a>`enddate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column production.workorder.enddate is @until-end-tag; -->Work order end date.<!-- end --> |
| <a id="user-content-production-workorder-duedate" href="#production-workorder-duedate">#</a>`duedate` |  | `timestamp without time zone` | **NO** |  | <!-- comment on column production.workorder.duedate is @until-end-tag; -->Work order due date.<!-- end --> |
| <a id="user-content-production-workorder-scrapreasonid" href="#production-workorder-scrapreasonid">#</a>`scrapreasonid` | **FK [➝](#production-scrapreason-scrapreasonid) `scrapreason.scrapreasonid`** | `smallint` | YES |  | <!-- comment on column production.workorder.scrapreasonid is @until-end-tag; -->Reason for inspection failure.<!-- end --> |
| <a id="user-content-production-workorder-modifieddate" href="#production-workorder-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.workorder.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `production.workorderrouting`

<!-- comment on table production.workorderrouting is @until-end-tag; -->
Work order details.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-production-workorderrouting-workorderid" href="#production-workorderrouting-workorderid">#</a>`workorderid` | **PK**, **FK [➝](#production-workorder-workorderid) `workorder.workorderid`** | `integer` | **NO** |  | <!-- comment on column production.workorderrouting.workorderid is @until-end-tag; -->Primary key. Foreign key to WorkOrder.WorkOrderID.<!-- end --> |
| <a id="user-content-production-workorderrouting-productid" href="#production-workorderrouting-productid">#</a>`productid` | **PK** | `integer` | **NO** |  | <!-- comment on column production.workorderrouting.productid is @until-end-tag; -->Primary key. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-production-workorderrouting-operationsequence" href="#production-workorderrouting-operationsequence">#</a>`operationsequence` | **PK** | `smallint` | **NO** |  | <!-- comment on column production.workorderrouting.operationsequence is @until-end-tag; -->Primary key. Indicates the manufacturing process sequence.<!-- end --> |
| <a id="user-content-production-workorderrouting-locationid" href="#production-workorderrouting-locationid">#</a>`locationid` | **FK [➝](#production-location-locationid) `location.locationid`** | `smallint` | **NO** |  | <!-- comment on column production.workorderrouting.locationid is @until-end-tag; -->Manufacturing location where the part is processed. Foreign key to Location.LocationID.<!-- end --> |
| <a id="user-content-production-workorderrouting-scheduledstartdate" href="#production-workorderrouting-scheduledstartdate">#</a>`scheduledstartdate` | CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column production.workorderrouting.scheduledstartdate is @until-end-tag; -->Planned manufacturing start date.<!-- end --> |
| <a id="user-content-production-workorderrouting-scheduledenddate" href="#production-workorderrouting-scheduledenddate">#</a>`scheduledenddate` | CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column production.workorderrouting.scheduledenddate is @until-end-tag; -->Planned manufacturing end date.<!-- end --> |
| <a id="user-content-production-workorderrouting-actualstartdate" href="#production-workorderrouting-actualstartdate">#</a>`actualstartdate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column production.workorderrouting.actualstartdate is @until-end-tag; -->Actual start date.<!-- end --> |
| <a id="user-content-production-workorderrouting-actualenddate" href="#production-workorderrouting-actualenddate">#</a>`actualenddate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column production.workorderrouting.actualenddate is @until-end-tag; -->Actual end date.<!-- end --> |
| <a id="user-content-production-workorderrouting-actualresourcehrs" href="#production-workorderrouting-actualresourcehrs">#</a>`actualresourcehrs` | CHECK | `numeric(9,10),4)` | YES |  | <!-- comment on column production.workorderrouting.actualresourcehrs is @until-end-tag; -->Number of manufacturing hours used.<!-- end --> |
| <a id="user-content-production-workorderrouting-plannedcost" href="#production-workorderrouting-plannedcost">#</a>`plannedcost` | CHECK | `numeric` | **NO** |  | <!-- comment on column production.workorderrouting.plannedcost is @until-end-tag; -->Estimated manufacturing cost.<!-- end --> |
| <a id="user-content-production-workorderrouting-actualcost" href="#production-workorderrouting-actualcost">#</a>`actualcost` | CHECK | `numeric` | YES |  | <!-- comment on column production.workorderrouting.actualcost is @until-end-tag; -->Actual manufacturing cost.<!-- end --> |
| <a id="user-content-production-workorderrouting-modifieddate" href="#production-workorderrouting-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column production.workorderrouting.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `purchasing.productvendor`

<!-- comment on table purchasing.productvendor is @until-end-tag; -->
Cross-reference table mapping vendors with the products they supply.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-purchasing-productvendor-productid" href="#purchasing-productvendor-productid">#</a>`productid` | **PK**, **FK [➝](#production-product-productid) `production.product.productid`** | `integer` | **NO** |  | <!-- comment on column purchasing.productvendor.productid is @until-end-tag; -->Primary key. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-purchasing-productvendor-businessentityid" href="#purchasing-productvendor-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#purchasing-vendor-businessentityid) `vendor.businessentityid`** | `integer` | **NO** |  | <!-- comment on column purchasing.productvendor.businessentityid is @until-end-tag; -->Primary key. Foreign key to Vendor.BusinessEntityID.<!-- end --> |
| <a id="user-content-purchasing-productvendor-averageleadtime" href="#purchasing-productvendor-averageleadtime">#</a>`averageleadtime` | CHECK | `integer` | **NO** |  | <!-- comment on column purchasing.productvendor.averageleadtime is @until-end-tag; -->The average span of time (in days) between placing an order with the vendor and receiving the purchased product.<!-- end --> |
| <a id="user-content-purchasing-productvendor-standardprice" href="#purchasing-productvendor-standardprice">#</a>`standardprice` | CHECK | `numeric` | **NO** |  | <!-- comment on column purchasing.productvendor.standardprice is @until-end-tag; -->The vendor's usual selling price.<!-- end --> |
| <a id="user-content-purchasing-productvendor-lastreceiptcost" href="#purchasing-productvendor-lastreceiptcost">#</a>`lastreceiptcost` | CHECK | `numeric` | YES |  | <!-- comment on column purchasing.productvendor.lastreceiptcost is @until-end-tag; -->The selling price when last purchased.<!-- end --> |
| <a id="user-content-purchasing-productvendor-lastreceiptdate" href="#purchasing-productvendor-lastreceiptdate">#</a>`lastreceiptdate` |  | `timestamp without time zone` | YES |  | <!-- comment on column purchasing.productvendor.lastreceiptdate is @until-end-tag; -->Date the product was last received by the vendor.<!-- end --> |
| <a id="user-content-purchasing-productvendor-minorderqty" href="#purchasing-productvendor-minorderqty">#</a>`minorderqty` | CHECK | `integer` | **NO** |  | <!-- comment on column purchasing.productvendor.minorderqty is @until-end-tag; -->The maximum quantity that should be ordered.<!-- end --> |
| <a id="user-content-purchasing-productvendor-maxorderqty" href="#purchasing-productvendor-maxorderqty">#</a>`maxorderqty` | CHECK | `integer` | **NO** |  | <!-- comment on column purchasing.productvendor.maxorderqty is @until-end-tag; -->The minimum quantity that should be ordered.<!-- end --> |
| <a id="user-content-purchasing-productvendor-onorderqty" href="#purchasing-productvendor-onorderqty">#</a>`onorderqty` | CHECK | `integer` | YES |  | <!-- comment on column purchasing.productvendor.onorderqty is @until-end-tag; -->The quantity currently on order.<!-- end --> |
| <a id="user-content-purchasing-productvendor-unitmeasurecode" href="#purchasing-productvendor-unitmeasurecode">#</a>`unitmeasurecode` | **FK [➝](#production-unitmeasure-unitmeasurecode) `production.unitmeasure.unitmeasurecode`** | `character(3)` | **NO** |  | <!-- comment on column purchasing.productvendor.unitmeasurecode is @until-end-tag; -->The product's unit of measure.<!-- end --> |
| <a id="user-content-purchasing-productvendor-modifieddate" href="#purchasing-productvendor-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column purchasing.productvendor.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `purchasing.purchaseorderdetail`

<!-- comment on table purchasing.purchaseorderdetail is @until-end-tag; -->
Individual products associated with a specific purchase order. See PurchaseOrderHeader.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-purchasing-purchaseorderdetail-purchaseorderid" href="#purchasing-purchaseorderdetail-purchaseorderid">#</a>`purchaseorderid` | **PK**, **FK [➝](#purchasing-purchaseorderheader-purchaseorderid) `purchaseorderheader.purchaseorderid`** | `integer` | **NO** |  | <!-- comment on column purchasing.purchaseorderdetail.purchaseorderid is @until-end-tag; -->Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderdetail-purchaseorderdetailid" href="#purchasing-purchaseorderdetail-purchaseorderdetailid">#</a>`purchaseorderdetailid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column purchasing.purchaseorderdetail.purchaseorderdetailid is @until-end-tag; -->Primary key. One line number per purchased product.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderdetail-duedate" href="#purchasing-purchaseorderdetail-duedate">#</a>`duedate` |  | `timestamp without time zone` | **NO** |  | <!-- comment on column purchasing.purchaseorderdetail.duedate is @until-end-tag; -->Date the product is expected to be received.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderdetail-orderqty" href="#purchasing-purchaseorderdetail-orderqty">#</a>`orderqty` | CHECK | `smallint` | **NO** |  | <!-- comment on column purchasing.purchaseorderdetail.orderqty is @until-end-tag; -->Quantity ordered.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderdetail-productid" href="#purchasing-purchaseorderdetail-productid">#</a>`productid` | **FK [➝](#production-product-productid) `production.product.productid`** | `integer` | **NO** |  | <!-- comment on column purchasing.purchaseorderdetail.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderdetail-unitprice" href="#purchasing-purchaseorderdetail-unitprice">#</a>`unitprice` | CHECK | `numeric` | **NO** |  | <!-- comment on column purchasing.purchaseorderdetail.unitprice is @until-end-tag; -->Vendor's selling price of a single product.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderdetail-receivedqty" href="#purchasing-purchaseorderdetail-receivedqty">#</a>`receivedqty` | CHECK | `numeric(8,10),2)` | **NO** |  | <!-- comment on column purchasing.purchaseorderdetail.receivedqty is @until-end-tag; -->Quantity actually received from the vendor.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderdetail-rejectedqty" href="#purchasing-purchaseorderdetail-rejectedqty">#</a>`rejectedqty` | CHECK | `numeric(8,10),2)` | **NO** |  | <!-- comment on column purchasing.purchaseorderdetail.rejectedqty is @until-end-tag; -->Quantity rejected during inspection.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderdetail-modifieddate" href="#purchasing-purchaseorderdetail-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column purchasing.purchaseorderdetail.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `purchasing.purchaseorderheader`

<!-- comment on table purchasing.purchaseorderheader is @until-end-tag; -->
General purchase order information. See PurchaseOrderDetail.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-purchasing-purchaseorderheader-purchaseorderid" href="#purchasing-purchaseorderheader-purchaseorderid">#</a>`purchaseorderid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column purchasing.purchaseorderheader.purchaseorderid is @until-end-tag; -->Primary key.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-revisionnumber" href="#purchasing-purchaseorderheader-revisionnumber">#</a>`revisionnumber` |  | `smallint` | **NO** | `0` | <!-- comment on column purchasing.purchaseorderheader.revisionnumber is @until-end-tag; -->Incremental number to track changes to the purchase order over time.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-status" href="#purchasing-purchaseorderheader-status">#</a>`status` | CHECK | `smallint` | **NO** | `1` | <!-- comment on column purchasing.purchaseorderheader.status is @until-end-tag; -->Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-employeeid" href="#purchasing-purchaseorderheader-employeeid">#</a>`employeeid` | **FK [➝](#humanresources-employee-businessentityid) `humanresources.employee.businessentityid`** | `integer` | **NO** |  | <!-- comment on column purchasing.purchaseorderheader.employeeid is @until-end-tag; -->Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-vendorid" href="#purchasing-purchaseorderheader-vendorid">#</a>`vendorid` | **FK [➝](#purchasing-vendor-businessentityid) `vendor.businessentityid`** | `integer` | **NO** |  | <!-- comment on column purchasing.purchaseorderheader.vendorid is @until-end-tag; -->Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-shipmethodid" href="#purchasing-purchaseorderheader-shipmethodid">#</a>`shipmethodid` | **FK [➝](#purchasing-shipmethod-shipmethodid) `shipmethod.shipmethodid`** | `integer` | **NO** |  | <!-- comment on column purchasing.purchaseorderheader.shipmethodid is @until-end-tag; -->Shipping method. Foreign key to ShipMethod.ShipMethodID.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-orderdate" href="#purchasing-purchaseorderheader-orderdate">#</a>`orderdate` | CHECK | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column purchasing.purchaseorderheader.orderdate is @until-end-tag; -->Purchase order creation date.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-shipdate" href="#purchasing-purchaseorderheader-shipdate">#</a>`shipdate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column purchasing.purchaseorderheader.shipdate is @until-end-tag; -->Estimated shipment date from the vendor.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-subtotal" href="#purchasing-purchaseorderheader-subtotal">#</a>`subtotal` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column purchasing.purchaseorderheader.subtotal is @until-end-tag; -->Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-taxamt" href="#purchasing-purchaseorderheader-taxamt">#</a>`taxamt` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column purchasing.purchaseorderheader.taxamt is @until-end-tag; -->Tax amount.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-freight" href="#purchasing-purchaseorderheader-freight">#</a>`freight` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column purchasing.purchaseorderheader.freight is @until-end-tag; -->Shipping cost.<!-- end --> |
| <a id="user-content-purchasing-purchaseorderheader-modifieddate" href="#purchasing-purchaseorderheader-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column purchasing.purchaseorderheader.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `purchasing.shipmethod`

<!-- comment on table purchasing.shipmethod is @until-end-tag; -->
Shipping company lookup table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-purchasing-shipmethod-shipmethodid" href="#purchasing-shipmethod-shipmethodid">#</a>`shipmethodid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column purchasing.shipmethod.shipmethodid is @until-end-tag; -->Primary key for ShipMethod records.<!-- end --> |
| <a id="user-content-purchasing-shipmethod-name" href="#purchasing-shipmethod-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column purchasing.shipmethod.name is @until-end-tag; -->Shipping company name.<!-- end --> |
| <a id="user-content-purchasing-shipmethod-shipbase" href="#purchasing-shipmethod-shipbase">#</a>`shipbase` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column purchasing.shipmethod.shipbase is @until-end-tag; -->Minimum shipping charge.<!-- end --> |
| <a id="user-content-purchasing-shipmethod-shiprate" href="#purchasing-shipmethod-shiprate">#</a>`shiprate` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column purchasing.shipmethod.shiprate is @until-end-tag; -->Shipping charge per pound.<!-- end --> |
| <a id="user-content-purchasing-shipmethod-rowguid" href="#purchasing-shipmethod-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column purchasing.shipmethod.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-purchasing-shipmethod-modifieddate" href="#purchasing-shipmethod-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column purchasing.shipmethod.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `purchasing.vendor`

<!-- comment on table purchasing.vendor is @until-end-tag; -->
Companies from whom Adventure Works Cycles purchases parts or other goods.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-purchasing-vendor-businessentityid" href="#purchasing-vendor-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-businessentity-businessentityid) `person.businessentity.businessentityid`** | `integer` | **NO** |  | <!-- comment on column purchasing.vendor.businessentityid is @until-end-tag; -->Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID<!-- end --> |
| <a id="user-content-purchasing-vendor-accountnumber" href="#purchasing-vendor-accountnumber">#</a>`accountnumber` |  | `character varying(15)` | **NO** |  | <!-- comment on column purchasing.vendor.accountnumber is @until-end-tag; -->Vendor account (identification) number.<!-- end --> |
| <a id="user-content-purchasing-vendor-name" href="#purchasing-vendor-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column purchasing.vendor.name is @until-end-tag; -->Company name.<!-- end --> |
| <a id="user-content-purchasing-vendor-creditrating" href="#purchasing-vendor-creditrating">#</a>`creditrating` | CHECK | `smallint` | **NO** |  | <!-- comment on column purchasing.vendor.creditrating is @until-end-tag; -->1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average<!-- end --> |
| <a id="user-content-purchasing-vendor-preferredvendorstatus" href="#purchasing-vendor-preferredvendorstatus">#</a>`preferredvendorstatus` |  | `boolean` | **NO** | `true` | <!-- comment on column purchasing.vendor.preferredvendorstatus is @until-end-tag; -->0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.<!-- end --> |
| <a id="user-content-purchasing-vendor-activeflag" href="#purchasing-vendor-activeflag">#</a>`activeflag` |  | `boolean` | **NO** | `true` | <!-- comment on column purchasing.vendor.activeflag is @until-end-tag; -->0 = Vendor no longer used. 1 = Vendor is actively used.<!-- end --> |
| <a id="user-content-purchasing-vendor-purchasingwebserviceurl" href="#purchasing-vendor-purchasingwebserviceurl">#</a>`purchasingwebserviceurl` |  | `character varying(1024)` | YES |  | <!-- comment on column purchasing.vendor.purchasingwebserviceurl is @until-end-tag; -->Vendor URL.<!-- end --> |
| <a id="user-content-purchasing-vendor-modifieddate" href="#purchasing-vendor-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column purchasing.vendor.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.countryregioncurrency`

<!-- comment on table sales.countryregioncurrency is @until-end-tag; -->
Cross-reference table mapping ISO currency codes to a country or region.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-countryregioncurrency-countryregioncode" href="#sales-countryregioncurrency-countryregioncode">#</a>`countryregioncode` | **PK**, **FK [➝](#person-countryregion-countryregioncode) `person.countryregion.countryregioncode`** | `character varying(3)` | **NO** |  | <!-- comment on column sales.countryregioncurrency.countryregioncode is @until-end-tag; -->ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.<!-- end --> |
| <a id="user-content-sales-countryregioncurrency-currencycode" href="#sales-countryregioncurrency-currencycode">#</a>`currencycode` | **PK**, **FK [➝](#sales-currency-currencycode) `currency.currencycode`** | `character(3)` | **NO** |  | <!-- comment on column sales.countryregioncurrency.currencycode is @until-end-tag; -->ISO standard currency code. Foreign key to Currency.CurrencyCode.<!-- end --> |
| <a id="user-content-sales-countryregioncurrency-modifieddate" href="#sales-countryregioncurrency-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.countryregioncurrency.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.creditcard`

<!-- comment on table sales.creditcard is @until-end-tag; -->
Customer credit card information.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-creditcard-creditcardid" href="#sales-creditcard-creditcardid">#</a>`creditcardid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.creditcard.creditcardid is @until-end-tag; -->Primary key for CreditCard records.<!-- end --> |
| <a id="user-content-sales-creditcard-cardtype" href="#sales-creditcard-cardtype">#</a>`cardtype` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.creditcard.cardtype is @until-end-tag; -->Credit card name.<!-- end --> |
| <a id="user-content-sales-creditcard-cardnumber" href="#sales-creditcard-cardnumber">#</a>`cardnumber` |  | `character varying(25)` | **NO** |  | <!-- comment on column sales.creditcard.cardnumber is @until-end-tag; -->Credit card number.<!-- end --> |
| <a id="user-content-sales-creditcard-expmonth" href="#sales-creditcard-expmonth">#</a>`expmonth` |  | `smallint` | **NO** |  | <!-- comment on column sales.creditcard.expmonth is @until-end-tag; -->Credit card expiration month.<!-- end --> |
| <a id="user-content-sales-creditcard-expyear" href="#sales-creditcard-expyear">#</a>`expyear` |  | `smallint` | **NO** |  | <!-- comment on column sales.creditcard.expyear is @until-end-tag; -->Credit card expiration year.<!-- end --> |
| <a id="user-content-sales-creditcard-modifieddate" href="#sales-creditcard-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.creditcard.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.currency`

<!-- comment on table sales.currency is @until-end-tag; -->
Lookup table containing standard ISO currencies.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-currency-currencycode" href="#sales-currency-currencycode">#</a>`currencycode` | **PK** | `character(3)` | **NO** |  | <!-- comment on column sales.currency.currencycode is @until-end-tag; -->The ISO code for the Currency.<!-- end --> |
| <a id="user-content-sales-currency-name" href="#sales-currency-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.currency.name is @until-end-tag; -->Currency name.<!-- end --> |
| <a id="user-content-sales-currency-modifieddate" href="#sales-currency-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.currency.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.currencyrate`

<!-- comment on table sales.currencyrate is @until-end-tag; -->
Currency exchange rates.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-currencyrate-currencyrateid" href="#sales-currencyrate-currencyrateid">#</a>`currencyrateid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.currencyrate.currencyrateid is @until-end-tag; -->Primary key for CurrencyRate records.<!-- end --> |
| <a id="user-content-sales-currencyrate-currencyratedate" href="#sales-currencyrate-currencyratedate">#</a>`currencyratedate` |  | `timestamp without time zone` | **NO** |  | <!-- comment on column sales.currencyrate.currencyratedate is @until-end-tag; -->Date and time the exchange rate was obtained.<!-- end --> |
| <a id="user-content-sales-currencyrate-fromcurrencycode" href="#sales-currencyrate-fromcurrencycode">#</a>`fromcurrencycode` | **FK [➝](#sales-currency-currencycode) `currency.currencycode`** | `character(3)` | **NO** |  | <!-- comment on column sales.currencyrate.fromcurrencycode is @until-end-tag; -->Exchange rate was converted from this currency code.<!-- end --> |
| <a id="user-content-sales-currencyrate-tocurrencycode" href="#sales-currencyrate-tocurrencycode">#</a>`tocurrencycode` | **FK [➝](#sales-currency-currencycode) `currency.currencycode`** | `character(3)` | **NO** |  | <!-- comment on column sales.currencyrate.tocurrencycode is @until-end-tag; -->Exchange rate was converted to this currency code.<!-- end --> |
| <a id="user-content-sales-currencyrate-averagerate" href="#sales-currencyrate-averagerate">#</a>`averagerate` |  | `numeric` | **NO** |  | <!-- comment on column sales.currencyrate.averagerate is @until-end-tag; -->Average exchange rate for the day.<!-- end --> |
| <a id="user-content-sales-currencyrate-endofdayrate" href="#sales-currencyrate-endofdayrate">#</a>`endofdayrate` |  | `numeric` | **NO** |  | <!-- comment on column sales.currencyrate.endofdayrate is @until-end-tag; -->Final exchange rate for the day.<!-- end --> |
| <a id="user-content-sales-currencyrate-modifieddate" href="#sales-currencyrate-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.currencyrate.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.customer`

<!-- comment on table sales.customer is @until-end-tag; -->
Current customer information. Also see the Person and Store tables.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-customer-customerid" href="#sales-customer-customerid">#</a>`customerid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.customer.customerid is @until-end-tag; -->Primary key.<!-- end --> |
| <a id="user-content-sales-customer-personid" href="#sales-customer-personid">#</a>`personid` | **FK [➝](#person-person-businessentityid) `person.person.businessentityid`** | `integer` | YES |  | <!-- comment on column sales.customer.personid is @until-end-tag; -->Foreign key to Person.BusinessEntityID<!-- end --> |
| <a id="user-content-sales-customer-storeid" href="#sales-customer-storeid">#</a>`storeid` | **FK [➝](#sales-store-businessentityid) `store.businessentityid`** | `integer` | YES |  | <!-- comment on column sales.customer.storeid is @until-end-tag; -->Foreign key to Store.BusinessEntityID<!-- end --> |
| <a id="user-content-sales-customer-territoryid" href="#sales-customer-territoryid">#</a>`territoryid` | **FK [➝](#sales-salesterritory-territoryid) `salesterritory.territoryid`** | `integer` | YES |  | <!-- comment on column sales.customer.territoryid is @until-end-tag; -->ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.<!-- end --> |
| <a id="user-content-sales-customer-rowguid" href="#sales-customer-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.customer.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-customer-modifieddate" href="#sales-customer-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.customer.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.personcreditcard`

<!-- comment on table sales.personcreditcard is @until-end-tag; -->
Cross-reference table mapping people to their credit card information in the CreditCard table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-personcreditcard-businessentityid" href="#sales-personcreditcard-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-person-businessentityid) `person.person.businessentityid`** | `integer` | **NO** |  | <!-- comment on column sales.personcreditcard.businessentityid is @until-end-tag; -->Business entity identification number. Foreign key to Person.BusinessEntityID.<!-- end --> |
| <a id="user-content-sales-personcreditcard-creditcardid" href="#sales-personcreditcard-creditcardid">#</a>`creditcardid` | **PK**, **FK [➝](#sales-creditcard-creditcardid) `creditcard.creditcardid`** | `integer` | **NO** |  | <!-- comment on column sales.personcreditcard.creditcardid is @until-end-tag; -->Credit card identification number. Foreign key to CreditCard.CreditCardID.<!-- end --> |
| <a id="user-content-sales-personcreditcard-modifieddate" href="#sales-personcreditcard-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.personcreditcard.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salesorderdetail`

<!-- comment on table sales.salesorderdetail is @until-end-tag; -->
Individual products associated with a specific sales order. See SalesOrderHeader.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salesorderdetail-salesorderid" href="#sales-salesorderdetail-salesorderid">#</a>`salesorderid` | **PK**, **FK [➝](#sales-salesorderheader-salesorderid) `salesorderheader.salesorderid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderdetail.salesorderid is @until-end-tag; -->Primary key. Foreign key to SalesOrderHeader.SalesOrderID.<!-- end --> |
| <a id="user-content-sales-salesorderdetail-salesorderdetailid" href="#sales-salesorderdetail-salesorderdetailid">#</a>`salesorderdetailid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.salesorderdetail.salesorderdetailid is @until-end-tag; -->Primary key. One incremental unique number per product sold.<!-- end --> |
| <a id="user-content-sales-salesorderdetail-carriertrackingnumber" href="#sales-salesorderdetail-carriertrackingnumber">#</a>`carriertrackingnumber` |  | `character varying(25)` | YES |  | <!-- comment on column sales.salesorderdetail.carriertrackingnumber is @until-end-tag; -->Shipment tracking number supplied by the shipper.<!-- end --> |
| <a id="user-content-sales-salesorderdetail-orderqty" href="#sales-salesorderdetail-orderqty">#</a>`orderqty` | CHECK | `smallint` | **NO** |  | <!-- comment on column sales.salesorderdetail.orderqty is @until-end-tag; -->Quantity ordered per product.<!-- end --> |
| <a id="user-content-sales-salesorderdetail-productid" href="#sales-salesorderdetail-productid">#</a>`productid` | **FK [➝](#sales-specialofferproduct-productid) `specialofferproduct.productid`**, **FK [➝](#sales-specialofferproduct-specialofferid) `specialofferproduct.specialofferid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderdetail.productid is @until-end-tag; -->Product sold to customer. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-sales-salesorderdetail-specialofferid" href="#sales-salesorderdetail-specialofferid">#</a>`specialofferid` | **FK [➝](#sales-specialofferproduct-productid) `specialofferproduct.productid`**, **FK [➝](#sales-specialofferproduct-specialofferid) `specialofferproduct.specialofferid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderdetail.specialofferid is @until-end-tag; -->Promotional code. Foreign key to SpecialOffer.SpecialOfferID.<!-- end --> |
| <a id="user-content-sales-salesorderdetail-unitprice" href="#sales-salesorderdetail-unitprice">#</a>`unitprice` | CHECK | `numeric` | **NO** |  | <!-- comment on column sales.salesorderdetail.unitprice is @until-end-tag; -->Selling price of a single product.<!-- end --> |
| <a id="user-content-sales-salesorderdetail-unitpricediscount" href="#sales-salesorderdetail-unitpricediscount">#</a>`unitpricediscount` | CHECK | `numeric` | **NO** | `0.0` | <!-- comment on column sales.salesorderdetail.unitpricediscount is @until-end-tag; -->Discount amount.<!-- end --> |
| <a id="user-content-sales-salesorderdetail-rowguid" href="#sales-salesorderdetail-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.salesorderdetail.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-salesorderdetail-modifieddate" href="#sales-salesorderdetail-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salesorderdetail.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salesorderheader`

<!-- comment on table sales.salesorderheader is @until-end-tag; -->
General sales order information.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salesorderheader-salesorderid" href="#sales-salesorderheader-salesorderid">#</a>`salesorderid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.salesorderheader.salesorderid is @until-end-tag; -->Primary key.<!-- end --> |
| <a id="user-content-sales-salesorderheader-revisionnumber" href="#sales-salesorderheader-revisionnumber">#</a>`revisionnumber` |  | `smallint` | **NO** | `0` | <!-- comment on column sales.salesorderheader.revisionnumber is @until-end-tag; -->Incremental number to track changes to the sales order over time.<!-- end --> |
| <a id="user-content-sales-salesorderheader-orderdate" href="#sales-salesorderheader-orderdate">#</a>`orderdate` | CHECK, CHECK | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salesorderheader.orderdate is @until-end-tag; -->Dates the sales order was created.<!-- end --> |
| <a id="user-content-sales-salesorderheader-duedate" href="#sales-salesorderheader-duedate">#</a>`duedate` | CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column sales.salesorderheader.duedate is @until-end-tag; -->Date the order is due to the customer.<!-- end --> |
| <a id="user-content-sales-salesorderheader-shipdate" href="#sales-salesorderheader-shipdate">#</a>`shipdate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column sales.salesorderheader.shipdate is @until-end-tag; -->Date the order was shipped to the customer.<!-- end --> |
| <a id="user-content-sales-salesorderheader-status" href="#sales-salesorderheader-status">#</a>`status` | CHECK | `smallint` | **NO** | `1` | <!-- comment on column sales.salesorderheader.status is @until-end-tag; -->Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled<!-- end --> |
| <a id="user-content-sales-salesorderheader-onlineorderflag" href="#sales-salesorderheader-onlineorderflag">#</a>`onlineorderflag` |  | `boolean` | **NO** | `true` | <!-- comment on column sales.salesorderheader.onlineorderflag is @until-end-tag; -->0 = Order placed by sales person. 1 = Order placed online by customer.<!-- end --> |
| <a id="user-content-sales-salesorderheader-purchaseordernumber" href="#sales-salesorderheader-purchaseordernumber">#</a>`purchaseordernumber` |  | `character varying(25)` | YES |  | <!-- comment on column sales.salesorderheader.purchaseordernumber is @until-end-tag; -->Customer purchase order number reference.<!-- end --> |
| <a id="user-content-sales-salesorderheader-accountnumber" href="#sales-salesorderheader-accountnumber">#</a>`accountnumber` |  | `character varying(15)` | YES |  | <!-- comment on column sales.salesorderheader.accountnumber is @until-end-tag; -->Financial accounting number reference.<!-- end --> |
| <a id="user-content-sales-salesorderheader-customerid" href="#sales-salesorderheader-customerid">#</a>`customerid` | **FK [➝](#sales-customer-customerid) `customer.customerid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderheader.customerid is @until-end-tag; -->Customer identification number. Foreign key to Customer.BusinessEntityID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-salespersonid" href="#sales-salesorderheader-salespersonid">#</a>`salespersonid` | **FK [➝](#sales-salesperson-businessentityid) `salesperson.businessentityid`** | `integer` | YES |  | <!-- comment on column sales.salesorderheader.salespersonid is @until-end-tag; -->Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-territoryid" href="#sales-salesorderheader-territoryid">#</a>`territoryid` | **FK [➝](#sales-salesterritory-territoryid) `salesterritory.territoryid`** | `integer` | YES |  | <!-- comment on column sales.salesorderheader.territoryid is @until-end-tag; -->Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-billtoaddressid" href="#sales-salesorderheader-billtoaddressid">#</a>`billtoaddressid` | **FK [➝](#person-address-addressid) `person.address.addressid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderheader.billtoaddressid is @until-end-tag; -->Customer billing address. Foreign key to Address.AddressID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-shiptoaddressid" href="#sales-salesorderheader-shiptoaddressid">#</a>`shiptoaddressid` | **FK [➝](#person-address-addressid) `person.address.addressid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderheader.shiptoaddressid is @until-end-tag; -->Customer shipping address. Foreign key to Address.AddressID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-shipmethodid" href="#sales-salesorderheader-shipmethodid">#</a>`shipmethodid` | **FK [➝](#purchasing-shipmethod-shipmethodid) `purchasing.shipmethod.shipmethodid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderheader.shipmethodid is @until-end-tag; -->Shipping method. Foreign key to ShipMethod.ShipMethodID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-creditcardid" href="#sales-salesorderheader-creditcardid">#</a>`creditcardid` | **FK [➝](#sales-creditcard-creditcardid) `creditcard.creditcardid`** | `integer` | YES |  | <!-- comment on column sales.salesorderheader.creditcardid is @until-end-tag; -->Credit card identification number. Foreign key to CreditCard.CreditCardID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-creditcardapprovalcode" href="#sales-salesorderheader-creditcardapprovalcode">#</a>`creditcardapprovalcode` |  | `character varying(15)` | YES |  | <!-- comment on column sales.salesorderheader.creditcardapprovalcode is @until-end-tag; -->Approval code provided by the credit card company.<!-- end --> |
| <a id="user-content-sales-salesorderheader-currencyrateid" href="#sales-salesorderheader-currencyrateid">#</a>`currencyrateid` | **FK [➝](#sales-currencyrate-currencyrateid) `currencyrate.currencyrateid`** | `integer` | YES |  | <!-- comment on column sales.salesorderheader.currencyrateid is @until-end-tag; -->Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-subtotal" href="#sales-salesorderheader-subtotal">#</a>`subtotal` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesorderheader.subtotal is @until-end-tag; -->Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.<!-- end --> |
| <a id="user-content-sales-salesorderheader-taxamt" href="#sales-salesorderheader-taxamt">#</a>`taxamt` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesorderheader.taxamt is @until-end-tag; -->Tax amount.<!-- end --> |
| <a id="user-content-sales-salesorderheader-freight" href="#sales-salesorderheader-freight">#</a>`freight` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesorderheader.freight is @until-end-tag; -->Shipping cost.<!-- end --> |
| <a id="user-content-sales-salesorderheader-totaldue" href="#sales-salesorderheader-totaldue">#</a>`totaldue` |  | `numeric` | YES |  | <!-- comment on column sales.salesorderheader.totaldue is @until-end-tag; -->Total due from customer. Computed as Subtotal + TaxAmt + Freight.<!-- end --> |
| <a id="user-content-sales-salesorderheader-comment" href="#sales-salesorderheader-comment">#</a>`comment` |  | `character varying(128)` | YES |  | <!-- comment on column sales.salesorderheader.comment is @until-end-tag; -->Sales representative comments.<!-- end --> |
| <a id="user-content-sales-salesorderheader-rowguid" href="#sales-salesorderheader-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.salesorderheader.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-salesorderheader-modifieddate" href="#sales-salesorderheader-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salesorderheader.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salesorderheadersalesreason`

<!-- comment on table sales.salesorderheadersalesreason is @until-end-tag; -->
Cross-reference table mapping sales orders to sales reason codes.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salesorderheadersalesreason-salesorderid" href="#sales-salesorderheadersalesreason-salesorderid">#</a>`salesorderid` | **PK**, **FK [➝](#sales-salesorderheader-salesorderid) `salesorderheader.salesorderid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderheadersalesreason.salesorderid is @until-end-tag; -->Primary key. Foreign key to SalesOrderHeader.SalesOrderID.<!-- end --> |
| <a id="user-content-sales-salesorderheadersalesreason-salesreasonid" href="#sales-salesorderheadersalesreason-salesreasonid">#</a>`salesreasonid` | **PK**, **FK [➝](#sales-salesreason-salesreasonid) `salesreason.salesreasonid`** | `integer` | **NO** |  | <!-- comment on column sales.salesorderheadersalesreason.salesreasonid is @until-end-tag; -->Primary key. Foreign key to SalesReason.SalesReasonID.<!-- end --> |
| <a id="user-content-sales-salesorderheadersalesreason-modifieddate" href="#sales-salesorderheadersalesreason-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salesorderheadersalesreason.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salesperson`

<!-- comment on table sales.salesperson is @until-end-tag; -->
Sales representative current information.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salesperson-businessentityid" href="#sales-salesperson-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#humanresources-employee-businessentityid) `humanresources.employee.businessentityid`** | `integer` | **NO** |  | <!-- comment on column sales.salesperson.businessentityid is @until-end-tag; -->Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID<!-- end --> |
| <a id="user-content-sales-salesperson-territoryid" href="#sales-salesperson-territoryid">#</a>`territoryid` | **FK [➝](#sales-salesterritory-territoryid) `salesterritory.territoryid`** | `integer` | YES |  | <!-- comment on column sales.salesperson.territoryid is @until-end-tag; -->Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.<!-- end --> |
| <a id="user-content-sales-salesperson-salesquota" href="#sales-salesperson-salesquota">#</a>`salesquota` | CHECK | `numeric` | YES |  | <!-- comment on column sales.salesperson.salesquota is @until-end-tag; -->Projected yearly sales.<!-- end --> |
| <a id="user-content-sales-salesperson-bonus" href="#sales-salesperson-bonus">#</a>`bonus` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesperson.bonus is @until-end-tag; -->Bonus due if quota is met.<!-- end --> |
| <a id="user-content-sales-salesperson-commissionpct" href="#sales-salesperson-commissionpct">#</a>`commissionpct` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesperson.commissionpct is @until-end-tag; -->Commision percent received per sale.<!-- end --> |
| <a id="user-content-sales-salesperson-salesytd" href="#sales-salesperson-salesytd">#</a>`salesytd` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesperson.salesytd is @until-end-tag; -->Sales total year to date.<!-- end --> |
| <a id="user-content-sales-salesperson-saleslastyear" href="#sales-salesperson-saleslastyear">#</a>`saleslastyear` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesperson.saleslastyear is @until-end-tag; -->Sales total of previous year.<!-- end --> |
| <a id="user-content-sales-salesperson-rowguid" href="#sales-salesperson-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.salesperson.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-salesperson-modifieddate" href="#sales-salesperson-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salesperson.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salespersonquotahistory`

<!-- comment on table sales.salespersonquotahistory is @until-end-tag; -->
Sales performance tracking.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salespersonquotahistory-businessentityid" href="#sales-salespersonquotahistory-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#sales-salesperson-businessentityid) `salesperson.businessentityid`** | `integer` | **NO** |  | <!-- comment on column sales.salespersonquotahistory.businessentityid is @until-end-tag; -->Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.<!-- end --> |
| <a id="user-content-sales-salespersonquotahistory-quotadate" href="#sales-salespersonquotahistory-quotadate">#</a>`quotadate` | **PK** | `timestamp without time zone` | **NO** |  | <!-- comment on column sales.salespersonquotahistory.quotadate is @until-end-tag; -->Sales quota date.<!-- end --> |
| <a id="user-content-sales-salespersonquotahistory-salesquota" href="#sales-salespersonquotahistory-salesquota">#</a>`salesquota` | CHECK | `numeric` | **NO** |  | <!-- comment on column sales.salespersonquotahistory.salesquota is @until-end-tag; -->Sales quota amount.<!-- end --> |
| <a id="user-content-sales-salespersonquotahistory-rowguid" href="#sales-salespersonquotahistory-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.salespersonquotahistory.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-salespersonquotahistory-modifieddate" href="#sales-salespersonquotahistory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salespersonquotahistory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salesreason`

<!-- comment on table sales.salesreason is @until-end-tag; -->
Lookup table of customer purchase reasons.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salesreason-salesreasonid" href="#sales-salesreason-salesreasonid">#</a>`salesreasonid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.salesreason.salesreasonid is @until-end-tag; -->Primary key for SalesReason records.<!-- end --> |
| <a id="user-content-sales-salesreason-name" href="#sales-salesreason-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.salesreason.name is @until-end-tag; -->Sales reason description.<!-- end --> |
| <a id="user-content-sales-salesreason-reasontype" href="#sales-salesreason-reasontype">#</a>`reasontype` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.salesreason.reasontype is @until-end-tag; -->Category the sales reason belongs to.<!-- end --> |
| <a id="user-content-sales-salesreason-modifieddate" href="#sales-salesreason-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salesreason.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salestaxrate`

<!-- comment on table sales.salestaxrate is @until-end-tag; -->
Tax rate lookup table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salestaxrate-salestaxrateid" href="#sales-salestaxrate-salestaxrateid">#</a>`salestaxrateid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.salestaxrate.salestaxrateid is @until-end-tag; -->Primary key for SalesTaxRate records.<!-- end --> |
| <a id="user-content-sales-salestaxrate-stateprovinceid" href="#sales-salestaxrate-stateprovinceid">#</a>`stateprovinceid` | **FK [➝](#person-stateprovince-stateprovinceid) `person.stateprovince.stateprovinceid`** | `integer` | **NO** |  | <!-- comment on column sales.salestaxrate.stateprovinceid is @until-end-tag; -->State, province, or country/region the sales tax applies to.<!-- end --> |
| <a id="user-content-sales-salestaxrate-taxtype" href="#sales-salestaxrate-taxtype">#</a>`taxtype` | CHECK | `smallint` | **NO** |  | <!-- comment on column sales.salestaxrate.taxtype is @until-end-tag; -->1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.<!-- end --> |
| <a id="user-content-sales-salestaxrate-taxrate" href="#sales-salestaxrate-taxrate">#</a>`taxrate` |  | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salestaxrate.taxrate is @until-end-tag; -->Tax rate amount.<!-- end --> |
| <a id="user-content-sales-salestaxrate-name" href="#sales-salestaxrate-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.salestaxrate.name is @until-end-tag; -->Tax rate description.<!-- end --> |
| <a id="user-content-sales-salestaxrate-rowguid" href="#sales-salestaxrate-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.salestaxrate.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-salestaxrate-modifieddate" href="#sales-salestaxrate-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salestaxrate.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salesterritory`

<!-- comment on table sales.salesterritory is @until-end-tag; -->
Sales territory lookup table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salesterritory-territoryid" href="#sales-salesterritory-territoryid">#</a>`territoryid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.salesterritory.territoryid is @until-end-tag; -->Primary key for SalesTerritory records.<!-- end --> |
| <a id="user-content-sales-salesterritory-name" href="#sales-salesterritory-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.salesterritory.name is @until-end-tag; -->Sales territory description<!-- end --> |
| <a id="user-content-sales-salesterritory-countryregioncode" href="#sales-salesterritory-countryregioncode">#</a>`countryregioncode` | **FK [➝](#person-countryregion-countryregioncode) `person.countryregion.countryregioncode`** | `character varying(3)` | **NO** |  | <!-- comment on column sales.salesterritory.countryregioncode is @until-end-tag; -->ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.<!-- end --> |
| <a id="user-content-sales-salesterritory-group" href="#sales-salesterritory-group">#</a>`group` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.salesterritory.group is @until-end-tag; -->Geographic area to which the sales territory belong.<!-- end --> |
| <a id="user-content-sales-salesterritory-salesytd" href="#sales-salesterritory-salesytd">#</a>`salesytd` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesterritory.salesytd is @until-end-tag; -->Sales in the territory year to date.<!-- end --> |
| <a id="user-content-sales-salesterritory-saleslastyear" href="#sales-salesterritory-saleslastyear">#</a>`saleslastyear` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesterritory.saleslastyear is @until-end-tag; -->Sales in the territory the previous year.<!-- end --> |
| <a id="user-content-sales-salesterritory-costytd" href="#sales-salesterritory-costytd">#</a>`costytd` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesterritory.costytd is @until-end-tag; -->Business costs in the territory year to date.<!-- end --> |
| <a id="user-content-sales-salesterritory-costlastyear" href="#sales-salesterritory-costlastyear">#</a>`costlastyear` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.salesterritory.costlastyear is @until-end-tag; -->Business costs in the territory the previous year.<!-- end --> |
| <a id="user-content-sales-salesterritory-rowguid" href="#sales-salesterritory-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.salesterritory.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-salesterritory-modifieddate" href="#sales-salesterritory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salesterritory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.salesterritoryhistory`

<!-- comment on table sales.salesterritoryhistory is @until-end-tag; -->
Sales representative transfers to other sales territories.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-salesterritoryhistory-businessentityid" href="#sales-salesterritoryhistory-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#sales-salesperson-businessentityid) `salesperson.businessentityid`** | `integer` | **NO** |  | <!-- comment on column sales.salesterritoryhistory.businessentityid is @until-end-tag; -->Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.<!-- end --> |
| <a id="user-content-sales-salesterritoryhistory-territoryid" href="#sales-salesterritoryhistory-territoryid">#</a>`territoryid` | **PK**, **FK [➝](#sales-salesterritory-territoryid) `salesterritory.territoryid`** | `integer` | **NO** |  | <!-- comment on column sales.salesterritoryhistory.territoryid is @until-end-tag; -->Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.<!-- end --> |
| <a id="user-content-sales-salesterritoryhistory-startdate" href="#sales-salesterritoryhistory-startdate">#</a>`startdate` | **PK**, CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column sales.salesterritoryhistory.startdate is @until-end-tag; -->Primary key. Date the sales representive started work in the territory.<!-- end --> |
| <a id="user-content-sales-salesterritoryhistory-enddate" href="#sales-salesterritoryhistory-enddate">#</a>`enddate` | CHECK | `timestamp without time zone` | YES |  | <!-- comment on column sales.salesterritoryhistory.enddate is @until-end-tag; -->Date the sales representative left work in the territory.<!-- end --> |
| <a id="user-content-sales-salesterritoryhistory-rowguid" href="#sales-salesterritoryhistory-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.salesterritoryhistory.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-salesterritoryhistory-modifieddate" href="#sales-salesterritoryhistory-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.salesterritoryhistory.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.shoppingcartitem`

<!-- comment on table sales.shoppingcartitem is @until-end-tag; -->
Contains online customer orders until the order is submitted or cancelled.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-shoppingcartitem-shoppingcartitemid" href="#sales-shoppingcartitem-shoppingcartitemid">#</a>`shoppingcartitemid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.shoppingcartitem.shoppingcartitemid is @until-end-tag; -->Primary key for ShoppingCartItem records.<!-- end --> |
| <a id="user-content-sales-shoppingcartitem-shoppingcartid" href="#sales-shoppingcartitem-shoppingcartid">#</a>`shoppingcartid` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.shoppingcartitem.shoppingcartid is @until-end-tag; -->Shopping cart identification number.<!-- end --> |
| <a id="user-content-sales-shoppingcartitem-quantity" href="#sales-shoppingcartitem-quantity">#</a>`quantity` | CHECK | `integer` | **NO** | `1` | <!-- comment on column sales.shoppingcartitem.quantity is @until-end-tag; -->Product quantity ordered.<!-- end --> |
| <a id="user-content-sales-shoppingcartitem-productid" href="#sales-shoppingcartitem-productid">#</a>`productid` | **FK [➝](#production-product-productid) `production.product.productid`** | `integer` | **NO** |  | <!-- comment on column sales.shoppingcartitem.productid is @until-end-tag; -->Product ordered. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-sales-shoppingcartitem-datecreated" href="#sales-shoppingcartitem-datecreated">#</a>`datecreated` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.shoppingcartitem.datecreated is @until-end-tag; -->Date the time the record was created.<!-- end --> |
| <a id="user-content-sales-shoppingcartitem-modifieddate" href="#sales-shoppingcartitem-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.shoppingcartitem.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.specialoffer`

<!-- comment on table sales.specialoffer is @until-end-tag; -->
Sale discounts lookup table.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-specialoffer-specialofferid" href="#sales-specialoffer-specialofferid">#</a>`specialofferid` | **PK** | `integer` | **NO** | *auto increment* | <!-- comment on column sales.specialoffer.specialofferid is @until-end-tag; -->Primary key for SpecialOffer records.<!-- end --> |
| <a id="user-content-sales-specialoffer-description" href="#sales-specialoffer-description">#</a>`description` |  | `character varying(255)` | **NO** |  | <!-- comment on column sales.specialoffer.description is @until-end-tag; -->Discount description.<!-- end --> |
| <a id="user-content-sales-specialoffer-discountpct" href="#sales-specialoffer-discountpct">#</a>`discountpct` | CHECK | `numeric` | **NO** | `0.00` | <!-- comment on column sales.specialoffer.discountpct is @until-end-tag; -->Discount precentage.<!-- end --> |
| <a id="user-content-sales-specialoffer-type" href="#sales-specialoffer-type">#</a>`type` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.specialoffer.type is @until-end-tag; -->Discount type category.<!-- end --> |
| <a id="user-content-sales-specialoffer-category" href="#sales-specialoffer-category">#</a>`category` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.specialoffer.category is @until-end-tag; -->Group the discount applies to such as Reseller or Customer.<!-- end --> |
| <a id="user-content-sales-specialoffer-startdate" href="#sales-specialoffer-startdate">#</a>`startdate` | CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column sales.specialoffer.startdate is @until-end-tag; -->Discount start date.<!-- end --> |
| <a id="user-content-sales-specialoffer-enddate" href="#sales-specialoffer-enddate">#</a>`enddate` | CHECK | `timestamp without time zone` | **NO** |  | <!-- comment on column sales.specialoffer.enddate is @until-end-tag; -->Discount end date.<!-- end --> |
| <a id="user-content-sales-specialoffer-minqty" href="#sales-specialoffer-minqty">#</a>`minqty` | CHECK | `integer` | **NO** | `0` | <!-- comment on column sales.specialoffer.minqty is @until-end-tag; -->Minimum discount percent allowed.<!-- end --> |
| <a id="user-content-sales-specialoffer-maxqty" href="#sales-specialoffer-maxqty">#</a>`maxqty` | CHECK | `integer` | YES |  | <!-- comment on column sales.specialoffer.maxqty is @until-end-tag; -->Maximum discount percent allowed.<!-- end --> |
| <a id="user-content-sales-specialoffer-rowguid" href="#sales-specialoffer-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.specialoffer.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-specialoffer-modifieddate" href="#sales-specialoffer-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.specialoffer.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.specialofferproduct`

<!-- comment on table sales.specialofferproduct is @until-end-tag; -->
Cross-reference table mapping products to special offer discounts.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-specialofferproduct-specialofferid" href="#sales-specialofferproduct-specialofferid">#</a>`specialofferid` | **PK**, **FK [➝](#sales-specialoffer-specialofferid) `specialoffer.specialofferid`** | `integer` | **NO** |  | <!-- comment on column sales.specialofferproduct.specialofferid is @until-end-tag; -->Primary key for SpecialOfferProduct records.<!-- end --> |
| <a id="user-content-sales-specialofferproduct-productid" href="#sales-specialofferproduct-productid">#</a>`productid` | **PK**, **FK [➝](#production-product-productid) `production.product.productid`** | `integer` | **NO** |  | <!-- comment on column sales.specialofferproduct.productid is @until-end-tag; -->Product identification number. Foreign key to Product.ProductID.<!-- end --> |
| <a id="user-content-sales-specialofferproduct-rowguid" href="#sales-specialofferproduct-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.specialofferproduct.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-specialofferproduct-modifieddate" href="#sales-specialofferproduct-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.specialofferproduct.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Table `sales.store`

<!-- comment on table sales.store is @until-end-tag; -->
Customers (resellers) of Adventure Works products.
<!-- end -->

| Column |             | Type | Nullable | Default | Comment |
| ------ | ----------- | -----| -------- | ------- | ------- |
| <a id="user-content-sales-store-businessentityid" href="#sales-store-businessentityid">#</a>`businessentityid` | **PK**, **FK [➝](#person-businessentity-businessentityid) `person.businessentity.businessentityid`** | `integer` | **NO** |  | <!-- comment on column sales.store.businessentityid is @until-end-tag; -->Primary key. Foreign key to Customer.BusinessEntityID.<!-- end --> |
| <a id="user-content-sales-store-name" href="#sales-store-name">#</a>`name` |  | `character varying(50)` | **NO** |  | <!-- comment on column sales.store.name is @until-end-tag; -->Name of the store.<!-- end --> |
| <a id="user-content-sales-store-salespersonid" href="#sales-store-salespersonid">#</a>`salespersonid` | **FK [➝](#sales-salesperson-businessentityid) `salesperson.businessentityid`** | `integer` | YES |  | <!-- comment on column sales.store.salespersonid is @until-end-tag; -->ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.<!-- end --> |
| <a id="user-content-sales-store-demographics" href="#sales-store-demographics">#</a>`demographics` |  | `xml` | YES |  | <!-- comment on column sales.store.demographics is @until-end-tag; -->Demographic informationg about the store such as the number of employees, annual sales and store type.<!-- end --> |
| <a id="user-content-sales-store-rowguid" href="#sales-store-rowguid">#</a>`rowguid` |  | `uuid` | **NO** | `uuid_generate_v1()` | <!-- comment on column sales.store.rowguid is @until-end-tag; --><!-- end --> |
| <a id="user-content-sales-store-modifieddate" href="#sales-store-modifieddate">#</a>`modifieddate` |  | `timestamp without time zone` | **NO** | `now()` | <!-- comment on column sales.store.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `hr.d`

<!-- comment on view hr.d is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column hr.d.id is @until-end-tag; --><!-- end --> |
| `departmentid` | `integer` | <!-- comment on column hr.d.departmentid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column hr.d.name is @until-end-tag; --><!-- end --> |
| `groupname` | `character varying(50)` | <!-- comment on column hr.d.groupname is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column hr.d.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `hr.e`

<!-- comment on view hr.e is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column hr.e.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column hr.e.businessentityid is @until-end-tag; --><!-- end --> |
| `nationalidnumber` | `character varying(15)` | <!-- comment on column hr.e.nationalidnumber is @until-end-tag; --><!-- end --> |
| `loginid` | `character varying(256)` | <!-- comment on column hr.e.loginid is @until-end-tag; --><!-- end --> |
| `jobtitle` | `character varying(50)` | <!-- comment on column hr.e.jobtitle is @until-end-tag; --><!-- end --> |
| `birthdate` | `date` | <!-- comment on column hr.e.birthdate is @until-end-tag; --><!-- end --> |
| `maritalstatus` | `character(1)` | <!-- comment on column hr.e.maritalstatus is @until-end-tag; --><!-- end --> |
| `gender` | `character(1)` | <!-- comment on column hr.e.gender is @until-end-tag; --><!-- end --> |
| `hiredate` | `date` | <!-- comment on column hr.e.hiredate is @until-end-tag; --><!-- end --> |
| `salariedflag` | `boolean` | <!-- comment on column hr.e.salariedflag is @until-end-tag; --><!-- end --> |
| `vacationhours` | `smallint` | <!-- comment on column hr.e.vacationhours is @until-end-tag; --><!-- end --> |
| `sickleavehours` | `smallint` | <!-- comment on column hr.e.sickleavehours is @until-end-tag; --><!-- end --> |
| `currentflag` | `boolean` | <!-- comment on column hr.e.currentflag is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column hr.e.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column hr.e.modifieddate is @until-end-tag; --><!-- end --> |
| `organizationnode` | `character varying` | <!-- comment on column hr.e.organizationnode is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `hr.edh`

<!-- comment on view hr.edh is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column hr.edh.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column hr.edh.businessentityid is @until-end-tag; --><!-- end --> |
| `departmentid` | `smallint` | <!-- comment on column hr.edh.departmentid is @until-end-tag; --><!-- end --> |
| `shiftid` | `smallint` | <!-- comment on column hr.edh.shiftid is @until-end-tag; --><!-- end --> |
| `startdate` | `date` | <!-- comment on column hr.edh.startdate is @until-end-tag; --><!-- end --> |
| `enddate` | `date` | <!-- comment on column hr.edh.enddate is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column hr.edh.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `hr.eph`

<!-- comment on view hr.eph is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column hr.eph.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column hr.eph.businessentityid is @until-end-tag; --><!-- end --> |
| `ratechangedate` | `timestamp without time zone` | <!-- comment on column hr.eph.ratechangedate is @until-end-tag; --><!-- end --> |
| `rate` | `numeric` | <!-- comment on column hr.eph.rate is @until-end-tag; --><!-- end --> |
| `payfrequency` | `smallint` | <!-- comment on column hr.eph.payfrequency is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column hr.eph.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `hr.jc`

<!-- comment on view hr.jc is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column hr.jc.id is @until-end-tag; --><!-- end --> |
| `jobcandidateid` | `integer` | <!-- comment on column hr.jc.jobcandidateid is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column hr.jc.businessentityid is @until-end-tag; --><!-- end --> |
| `resume` | `xml` | <!-- comment on column hr.jc.resume is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column hr.jc.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `hr.s`

<!-- comment on view hr.s is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column hr.s.id is @until-end-tag; --><!-- end --> |
| `shiftid` | `integer` | <!-- comment on column hr.s.shiftid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column hr.s.name is @until-end-tag; --><!-- end --> |
| `starttime` | `time without time zone` | <!-- comment on column hr.s.starttime is @until-end-tag; --><!-- end --> |
| `endtime` | `time without time zone` | <!-- comment on column hr.s.endtime is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column hr.s.modifieddate is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `humanresources.vemployee`

<!-- comment on view humanresources.vemployee is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column humanresources.vemployee.businessentityid is @until-end-tag; --><!-- end --> |
| `title` | `character varying(8)` | <!-- comment on column humanresources.vemployee.title is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column humanresources.vemployee.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column humanresources.vemployee.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column humanresources.vemployee.lastname is @until-end-tag; --><!-- end --> |
| `suffix` | `character varying(10)` | <!-- comment on column humanresources.vemployee.suffix is @until-end-tag; --><!-- end --> |
| `jobtitle` | `character varying(50)` | <!-- comment on column humanresources.vemployee.jobtitle is @until-end-tag; --><!-- end --> |
| `phonenumber` | `character varying(25)` | <!-- comment on column humanresources.vemployee.phonenumber is @until-end-tag; --><!-- end --> |
| `phonenumbertype` | `character varying(50)` | <!-- comment on column humanresources.vemployee.phonenumbertype is @until-end-tag; --><!-- end --> |
| `emailaddress` | `character varying(50)` | <!-- comment on column humanresources.vemployee.emailaddress is @until-end-tag; --><!-- end --> |
| `emailpromotion` | `integer` | <!-- comment on column humanresources.vemployee.emailpromotion is @until-end-tag; --><!-- end --> |
| `addressline1` | `character varying(60)` | <!-- comment on column humanresources.vemployee.addressline1 is @until-end-tag; --><!-- end --> |
| `addressline2` | `character varying(60)` | <!-- comment on column humanresources.vemployee.addressline2 is @until-end-tag; --><!-- end --> |
| `city` | `character varying(30)` | <!-- comment on column humanresources.vemployee.city is @until-end-tag; --><!-- end --> |
| `stateprovincename` | `character varying(50)` | <!-- comment on column humanresources.vemployee.stateprovincename is @until-end-tag; --><!-- end --> |
| `postalcode` | `character varying(15)` | <!-- comment on column humanresources.vemployee.postalcode is @until-end-tag; --><!-- end --> |
| `countryregionname` | `character varying(50)` | <!-- comment on column humanresources.vemployee.countryregionname is @until-end-tag; --><!-- end --> |
| `additionalcontactinfo` | `xml` | <!-- comment on column humanresources.vemployee.additionalcontactinfo is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `humanresources.vemployeedepartment`

<!-- comment on view humanresources.vemployeedepartment is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column humanresources.vemployeedepartment.businessentityid is @until-end-tag; --><!-- end --> |
| `title` | `character varying(8)` | <!-- comment on column humanresources.vemployeedepartment.title is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartment.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartment.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartment.lastname is @until-end-tag; --><!-- end --> |
| `suffix` | `character varying(10)` | <!-- comment on column humanresources.vemployeedepartment.suffix is @until-end-tag; --><!-- end --> |
| `jobtitle` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartment.jobtitle is @until-end-tag; --><!-- end --> |
| `department` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartment.department is @until-end-tag; --><!-- end --> |
| `groupname` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartment.groupname is @until-end-tag; --><!-- end --> |
| `startdate` | `date` | <!-- comment on column humanresources.vemployeedepartment.startdate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `humanresources.vemployeedepartmenthistory`

<!-- comment on view humanresources.vemployeedepartmenthistory is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column humanresources.vemployeedepartmenthistory.businessentityid is @until-end-tag; --><!-- end --> |
| `title` | `character varying(8)` | <!-- comment on column humanresources.vemployeedepartmenthistory.title is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartmenthistory.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartmenthistory.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartmenthistory.lastname is @until-end-tag; --><!-- end --> |
| `suffix` | `character varying(10)` | <!-- comment on column humanresources.vemployeedepartmenthistory.suffix is @until-end-tag; --><!-- end --> |
| `shift` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartmenthistory.shift is @until-end-tag; --><!-- end --> |
| `department` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartmenthistory.department is @until-end-tag; --><!-- end --> |
| `groupname` | `character varying(50)` | <!-- comment on column humanresources.vemployeedepartmenthistory.groupname is @until-end-tag; --><!-- end --> |
| `startdate` | `date` | <!-- comment on column humanresources.vemployeedepartmenthistory.startdate is @until-end-tag; --><!-- end --> |
| `enddate` | `date` | <!-- comment on column humanresources.vemployeedepartmenthistory.enddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `humanresources.vjobcandidate`

<!-- comment on view humanresources.vjobcandidate is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `jobcandidateid` | `integer` | <!-- comment on column humanresources.vjobcandidate.jobcandidateid is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column humanresources.vjobcandidate.businessentityid is @until-end-tag; --><!-- end --> |
| `Name.Prefix` | `character varying(30)` | <!-- comment on column humanresources.vjobcandidate.Name.Prefix is @until-end-tag; --><!-- end --> |
| `Name.First` | `character varying(30)` | <!-- comment on column humanresources.vjobcandidate.Name.First is @until-end-tag; --><!-- end --> |
| `Name.Middle` | `character varying(30)` | <!-- comment on column humanresources.vjobcandidate.Name.Middle is @until-end-tag; --><!-- end --> |
| `Name.Last` | `character varying(30)` | <!-- comment on column humanresources.vjobcandidate.Name.Last is @until-end-tag; --><!-- end --> |
| `Name.Suffix` | `character varying(30)` | <!-- comment on column humanresources.vjobcandidate.Name.Suffix is @until-end-tag; --><!-- end --> |
| `Skills` | `character varying` | <!-- comment on column humanresources.vjobcandidate.Skills is @until-end-tag; --><!-- end --> |
| `Addr.Type` | `character varying(30)` | <!-- comment on column humanresources.vjobcandidate.Addr.Type is @until-end-tag; --><!-- end --> |
| `Addr.Loc.CountryRegion` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidate.Addr.Loc.CountryRegion is @until-end-tag; --><!-- end --> |
| `Addr.Loc.State` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidate.Addr.Loc.State is @until-end-tag; --><!-- end --> |
| `Addr.Loc.City` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidate.Addr.Loc.City is @until-end-tag; --><!-- end --> |
| `Addr.PostalCode` | `character varying(20)` | <!-- comment on column humanresources.vjobcandidate.Addr.PostalCode is @until-end-tag; --><!-- end --> |
| `EMail` | `character varying` | <!-- comment on column humanresources.vjobcandidate.EMail is @until-end-tag; --><!-- end --> |
| `WebSite` | `character varying` | <!-- comment on column humanresources.vjobcandidate.WebSite is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column humanresources.vjobcandidate.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `humanresources.vjobcandidateeducation`

<!-- comment on view humanresources.vjobcandidateeducation is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `jobcandidateid` | `integer` | <!-- comment on column humanresources.vjobcandidateeducation.jobcandidateid is @until-end-tag; --><!-- end --> |
| `Edu.Level` | `character varying(50)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.Level is @until-end-tag; --><!-- end --> |
| `Edu.StartDate` | `date` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.StartDate is @until-end-tag; --><!-- end --> |
| `Edu.EndDate` | `date` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.EndDate is @until-end-tag; --><!-- end --> |
| `Edu.Degree` | `character varying(50)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.Degree is @until-end-tag; --><!-- end --> |
| `Edu.Major` | `character varying(50)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.Major is @until-end-tag; --><!-- end --> |
| `Edu.Minor` | `character varying(50)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.Minor is @until-end-tag; --><!-- end --> |
| `Edu.GPA` | `character varying(5)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.GPA is @until-end-tag; --><!-- end --> |
| `Edu.GPAScale` | `character varying(5)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.GPAScale is @until-end-tag; --><!-- end --> |
| `Edu.School` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.School is @until-end-tag; --><!-- end --> |
| `Edu.Loc.CountryRegion` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.Loc.CountryRegion is @until-end-tag; --><!-- end --> |
| `Edu.Loc.State` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.Loc.State is @until-end-tag; --><!-- end --> |
| `Edu.Loc.City` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidateeducation.Edu.Loc.City is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `humanresources.vjobcandidateemployment`

<!-- comment on view humanresources.vjobcandidateemployment is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `jobcandidateid` | `integer` | <!-- comment on column humanresources.vjobcandidateemployment.jobcandidateid is @until-end-tag; --><!-- end --> |
| `Emp.StartDate` | `date` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.StartDate is @until-end-tag; --><!-- end --> |
| `Emp.EndDate` | `date` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.EndDate is @until-end-tag; --><!-- end --> |
| `Emp.OrgName` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.OrgName is @until-end-tag; --><!-- end --> |
| `Emp.JobTitle` | `character varying(100)` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.JobTitle is @until-end-tag; --><!-- end --> |
| `Emp.Responsibility` | `character varying` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.Responsibility is @until-end-tag; --><!-- end --> |
| `Emp.FunctionCategory` | `character varying` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.FunctionCategory is @until-end-tag; --><!-- end --> |
| `Emp.IndustryCategory` | `character varying` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.IndustryCategory is @until-end-tag; --><!-- end --> |
| `Emp.Loc.CountryRegion` | `character varying` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.Loc.CountryRegion is @until-end-tag; --><!-- end --> |
| `Emp.Loc.State` | `character varying` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.Loc.State is @until-end-tag; --><!-- end --> |
| `Emp.Loc.City` | `character varying` | <!-- comment on column humanresources.vjobcandidateemployment.Emp.Loc.City is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.a`

<!-- comment on view pe.a is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.a.id is @until-end-tag; --><!-- end --> |
| `addressid` | `integer` | <!-- comment on column pe.a.addressid is @until-end-tag; --><!-- end --> |
| `addressline1` | `character varying(60)` | <!-- comment on column pe.a.addressline1 is @until-end-tag; --><!-- end --> |
| `addressline2` | `character varying(60)` | <!-- comment on column pe.a.addressline2 is @until-end-tag; --><!-- end --> |
| `city` | `character varying(30)` | <!-- comment on column pe.a.city is @until-end-tag; --><!-- end --> |
| `stateprovinceid` | `integer` | <!-- comment on column pe.a.stateprovinceid is @until-end-tag; --><!-- end --> |
| `postalcode` | `character varying(15)` | <!-- comment on column pe.a.postalcode is @until-end-tag; --><!-- end --> |
| `spatiallocation` | `character varying(44)` | <!-- comment on column pe.a.spatiallocation is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.a.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.a.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.at`

<!-- comment on view pe.at is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.at.id is @until-end-tag; --><!-- end --> |
| `addresstypeid` | `integer` | <!-- comment on column pe.at.addresstypeid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pe.at.name is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.at.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.at.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.be`

<!-- comment on view pe.be is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.be.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pe.be.businessentityid is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.be.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.be.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.bea`

<!-- comment on view pe.bea is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.bea.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pe.bea.businessentityid is @until-end-tag; --><!-- end --> |
| `addressid` | `integer` | <!-- comment on column pe.bea.addressid is @until-end-tag; --><!-- end --> |
| `addresstypeid` | `integer` | <!-- comment on column pe.bea.addresstypeid is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.bea.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.bea.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.bec`

<!-- comment on view pe.bec is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.bec.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pe.bec.businessentityid is @until-end-tag; --><!-- end --> |
| `personid` | `integer` | <!-- comment on column pe.bec.personid is @until-end-tag; --><!-- end --> |
| `contacttypeid` | `integer` | <!-- comment on column pe.bec.contacttypeid is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.bec.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.bec.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.cr`

<!-- comment on view pe.cr is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `countryregioncode` | `character varying(3)` | <!-- comment on column pe.cr.countryregioncode is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pe.cr.name is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.cr.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.ct`

<!-- comment on view pe.ct is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.ct.id is @until-end-tag; --><!-- end --> |
| `contacttypeid` | `integer` | <!-- comment on column pe.ct.contacttypeid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pe.ct.name is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.ct.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.e`

<!-- comment on view pe.e is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.e.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pe.e.businessentityid is @until-end-tag; --><!-- end --> |
| `emailaddressid` | `integer` | <!-- comment on column pe.e.emailaddressid is @until-end-tag; --><!-- end --> |
| `emailaddress` | `character varying(50)` | <!-- comment on column pe.e.emailaddress is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.e.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.e.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.p`

<!-- comment on view pe.p is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.p.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pe.p.businessentityid is @until-end-tag; --><!-- end --> |
| `persontype` | `character(2)` | <!-- comment on column pe.p.persontype is @until-end-tag; --><!-- end --> |
| `namestyle` | `boolean` | <!-- comment on column pe.p.namestyle is @until-end-tag; --><!-- end --> |
| `title` | `character varying(8)` | <!-- comment on column pe.p.title is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column pe.p.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column pe.p.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column pe.p.lastname is @until-end-tag; --><!-- end --> |
| `suffix` | `character varying(10)` | <!-- comment on column pe.p.suffix is @until-end-tag; --><!-- end --> |
| `emailpromotion` | `integer` | <!-- comment on column pe.p.emailpromotion is @until-end-tag; --><!-- end --> |
| `additionalcontactinfo` | `xml` | <!-- comment on column pe.p.additionalcontactinfo is @until-end-tag; --><!-- end --> |
| `demographics` | `xml` | <!-- comment on column pe.p.demographics is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.p.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.p.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.pa`

<!-- comment on view pe.pa is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.pa.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pe.pa.businessentityid is @until-end-tag; --><!-- end --> |
| `passwordhash` | `character varying(128)` | <!-- comment on column pe.pa.passwordhash is @until-end-tag; --><!-- end --> |
| `passwordsalt` | `character varying(10)` | <!-- comment on column pe.pa.passwordsalt is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.pa.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.pa.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.pnt`

<!-- comment on view pe.pnt is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.pnt.id is @until-end-tag; --><!-- end --> |
| `phonenumbertypeid` | `integer` | <!-- comment on column pe.pnt.phonenumbertypeid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pe.pnt.name is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.pnt.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.pp`

<!-- comment on view pe.pp is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.pp.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pe.pp.businessentityid is @until-end-tag; --><!-- end --> |
| `phonenumber` | `character varying(25)` | <!-- comment on column pe.pp.phonenumber is @until-end-tag; --><!-- end --> |
| `phonenumbertypeid` | `integer` | <!-- comment on column pe.pp.phonenumbertypeid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.pp.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pe.sp`

<!-- comment on view pe.sp is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pe.sp.id is @until-end-tag; --><!-- end --> |
| `stateprovinceid` | `integer` | <!-- comment on column pe.sp.stateprovinceid is @until-end-tag; --><!-- end --> |
| `stateprovincecode` | `character(3)` | <!-- comment on column pe.sp.stateprovincecode is @until-end-tag; --><!-- end --> |
| `countryregioncode` | `character varying(3)` | <!-- comment on column pe.sp.countryregioncode is @until-end-tag; --><!-- end --> |
| `isonlystateprovinceflag` | `boolean` | <!-- comment on column pe.sp.isonlystateprovinceflag is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pe.sp.name is @until-end-tag; --><!-- end --> |
| `territoryid` | `integer` | <!-- comment on column pe.sp.territoryid is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pe.sp.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pe.sp.modifieddate is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `person.vadditionalcontactinfo`

<!-- comment on view person.vadditionalcontactinfo is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column person.vadditionalcontactinfo.businessentityid is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column person.vadditionalcontactinfo.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column person.vadditionalcontactinfo.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column person.vadditionalcontactinfo.lastname is @until-end-tag; --><!-- end --> |
| `telephonenumber` | `xml` | <!-- comment on column person.vadditionalcontactinfo.telephonenumber is @until-end-tag; --><!-- end --> |
| `telephonespecialinstructions` | `text` | <!-- comment on column person.vadditionalcontactinfo.telephonespecialinstructions is @until-end-tag; --><!-- end --> |
| `street` | `xml` | <!-- comment on column person.vadditionalcontactinfo.street is @until-end-tag; --><!-- end --> |
| `city` | `xml` | <!-- comment on column person.vadditionalcontactinfo.city is @until-end-tag; --><!-- end --> |
| `stateprovince` | `xml` | <!-- comment on column person.vadditionalcontactinfo.stateprovince is @until-end-tag; --><!-- end --> |
| `postalcode` | `xml` | <!-- comment on column person.vadditionalcontactinfo.postalcode is @until-end-tag; --><!-- end --> |
| `countryregion` | `xml` | <!-- comment on column person.vadditionalcontactinfo.countryregion is @until-end-tag; --><!-- end --> |
| `homeaddressspecialinstructions` | `xml` | <!-- comment on column person.vadditionalcontactinfo.homeaddressspecialinstructions is @until-end-tag; --><!-- end --> |
| `emailaddress` | `xml` | <!-- comment on column person.vadditionalcontactinfo.emailaddress is @until-end-tag; --><!-- end --> |
| `emailspecialinstructions` | `text` | <!-- comment on column person.vadditionalcontactinfo.emailspecialinstructions is @until-end-tag; --><!-- end --> |
| `emailtelephonenumber` | `xml` | <!-- comment on column person.vadditionalcontactinfo.emailtelephonenumber is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column person.vadditionalcontactinfo.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column person.vadditionalcontactinfo.modifieddate is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.bom`

<!-- comment on view pr.bom is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.bom.id is @until-end-tag; --><!-- end --> |
| `billofmaterialsid` | `integer` | <!-- comment on column pr.bom.billofmaterialsid is @until-end-tag; --><!-- end --> |
| `productassemblyid` | `integer` | <!-- comment on column pr.bom.productassemblyid is @until-end-tag; --><!-- end --> |
| `componentid` | `integer` | <!-- comment on column pr.bom.componentid is @until-end-tag; --><!-- end --> |
| `startdate` | `timestamp without time zone` | <!-- comment on column pr.bom.startdate is @until-end-tag; --><!-- end --> |
| `enddate` | `timestamp without time zone` | <!-- comment on column pr.bom.enddate is @until-end-tag; --><!-- end --> |
| `unitmeasurecode` | `character(3)` | <!-- comment on column pr.bom.unitmeasurecode is @until-end-tag; --><!-- end --> |
| `bomlevel` | `smallint` | <!-- comment on column pr.bom.bomlevel is @until-end-tag; --><!-- end --> |
| `perassemblyqty` | `numeric(8,10),2)` | <!-- comment on column pr.bom.perassemblyqty is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.bom.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.c`

<!-- comment on view pr.c is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `character(6)` | <!-- comment on column pr.c.id is @until-end-tag; --><!-- end --> |
| `cultureid` | `character(6)` | <!-- comment on column pr.c.cultureid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pr.c.name is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.c.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.d`

<!-- comment on view pr.d is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `title` | `character varying(50)` | <!-- comment on column pr.d.title is @until-end-tag; --><!-- end --> |
| `owner` | `integer` | <!-- comment on column pr.d.owner is @until-end-tag; --><!-- end --> |
| `folderflag` | `boolean` | <!-- comment on column pr.d.folderflag is @until-end-tag; --><!-- end --> |
| `filename` | `character varying(400)` | <!-- comment on column pr.d.filename is @until-end-tag; --><!-- end --> |
| `fileextension` | `character varying(8)` | <!-- comment on column pr.d.fileextension is @until-end-tag; --><!-- end --> |
| `revision` | `character(5)` | <!-- comment on column pr.d.revision is @until-end-tag; --><!-- end --> |
| `changenumber` | `integer` | <!-- comment on column pr.d.changenumber is @until-end-tag; --><!-- end --> |
| `status` | `smallint` | <!-- comment on column pr.d.status is @until-end-tag; --><!-- end --> |
| `documentsummary` | `text` | <!-- comment on column pr.d.documentsummary is @until-end-tag; --><!-- end --> |
| `document` | `bytea` | <!-- comment on column pr.d.document is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pr.d.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.d.modifieddate is @until-end-tag; --><!-- end --> |
| `documentnode` | `character varying` | <!-- comment on column pr.d.documentnode is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.i`

<!-- comment on view pr.i is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.i.id is @until-end-tag; --><!-- end --> |
| `illustrationid` | `integer` | <!-- comment on column pr.i.illustrationid is @until-end-tag; --><!-- end --> |
| `diagram` | `xml` | <!-- comment on column pr.i.diagram is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.i.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.l`

<!-- comment on view pr.l is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.l.id is @until-end-tag; --><!-- end --> |
| `locationid` | `integer` | <!-- comment on column pr.l.locationid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pr.l.name is @until-end-tag; --><!-- end --> |
| `costrate` | `numeric` | <!-- comment on column pr.l.costrate is @until-end-tag; --><!-- end --> |
| `availability` | `numeric(8,10),2)` | <!-- comment on column pr.l.availability is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.l.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.p`

<!-- comment on view pr.p is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.p.id is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.p.productid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pr.p.name is @until-end-tag; --><!-- end --> |
| `productnumber` | `character varying(25)` | <!-- comment on column pr.p.productnumber is @until-end-tag; --><!-- end --> |
| `makeflag` | `boolean` | <!-- comment on column pr.p.makeflag is @until-end-tag; --><!-- end --> |
| `finishedgoodsflag` | `boolean` | <!-- comment on column pr.p.finishedgoodsflag is @until-end-tag; --><!-- end --> |
| `color` | `character varying(15)` | <!-- comment on column pr.p.color is @until-end-tag; --><!-- end --> |
| `safetystocklevel` | `smallint` | <!-- comment on column pr.p.safetystocklevel is @until-end-tag; --><!-- end --> |
| `reorderpoint` | `smallint` | <!-- comment on column pr.p.reorderpoint is @until-end-tag; --><!-- end --> |
| `standardcost` | `numeric` | <!-- comment on column pr.p.standardcost is @until-end-tag; --><!-- end --> |
| `listprice` | `numeric` | <!-- comment on column pr.p.listprice is @until-end-tag; --><!-- end --> |
| `size` | `character varying(5)` | <!-- comment on column pr.p.size is @until-end-tag; --><!-- end --> |
| `sizeunitmeasurecode` | `character(3)` | <!-- comment on column pr.p.sizeunitmeasurecode is @until-end-tag; --><!-- end --> |
| `weightunitmeasurecode` | `character(3)` | <!-- comment on column pr.p.weightunitmeasurecode is @until-end-tag; --><!-- end --> |
| `weight` | `numeric(8,10),2)` | <!-- comment on column pr.p.weight is @until-end-tag; --><!-- end --> |
| `daystomanufacture` | `integer` | <!-- comment on column pr.p.daystomanufacture is @until-end-tag; --><!-- end --> |
| `productline` | `character(2)` | <!-- comment on column pr.p.productline is @until-end-tag; --><!-- end --> |
| `class` | `character(2)` | <!-- comment on column pr.p.class is @until-end-tag; --><!-- end --> |
| `style` | `character(2)` | <!-- comment on column pr.p.style is @until-end-tag; --><!-- end --> |
| `productsubcategoryid` | `integer` | <!-- comment on column pr.p.productsubcategoryid is @until-end-tag; --><!-- end --> |
| `productmodelid` | `integer` | <!-- comment on column pr.p.productmodelid is @until-end-tag; --><!-- end --> |
| `sellstartdate` | `timestamp without time zone` | <!-- comment on column pr.p.sellstartdate is @until-end-tag; --><!-- end --> |
| `sellenddate` | `timestamp without time zone` | <!-- comment on column pr.p.sellenddate is @until-end-tag; --><!-- end --> |
| `discontinueddate` | `timestamp without time zone` | <!-- comment on column pr.p.discontinueddate is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pr.p.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.p.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pc`

<!-- comment on view pr.pc is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.pc.id is @until-end-tag; --><!-- end --> |
| `productcategoryid` | `integer` | <!-- comment on column pr.pc.productcategoryid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pr.pc.name is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pr.pc.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pc.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pch`

<!-- comment on view pr.pch is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.pch.id is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.pch.productid is @until-end-tag; --><!-- end --> |
| `startdate` | `timestamp without time zone` | <!-- comment on column pr.pch.startdate is @until-end-tag; --><!-- end --> |
| `enddate` | `timestamp without time zone` | <!-- comment on column pr.pch.enddate is @until-end-tag; --><!-- end --> |
| `standardcost` | `numeric` | <!-- comment on column pr.pch.standardcost is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pch.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pd`

<!-- comment on view pr.pd is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.pd.id is @until-end-tag; --><!-- end --> |
| `productdescriptionid` | `integer` | <!-- comment on column pr.pd.productdescriptionid is @until-end-tag; --><!-- end --> |
| `description` | `character varying(400)` | <!-- comment on column pr.pd.description is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pr.pd.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pd.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pdoc`

<!-- comment on view pr.pdoc is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.pdoc.id is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.pdoc.productid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pdoc.modifieddate is @until-end-tag; --><!-- end --> |
| `documentnode` | `character varying` | <!-- comment on column pr.pdoc.documentnode is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pi`

<!-- comment on view pr.pi is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.pi.id is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.pi.productid is @until-end-tag; --><!-- end --> |
| `locationid` | `smallint` | <!-- comment on column pr.pi.locationid is @until-end-tag; --><!-- end --> |
| `shelf` | `character varying(10)` | <!-- comment on column pr.pi.shelf is @until-end-tag; --><!-- end --> |
| `bin` | `smallint` | <!-- comment on column pr.pi.bin is @until-end-tag; --><!-- end --> |
| `quantity` | `smallint` | <!-- comment on column pr.pi.quantity is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pr.pi.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pi.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.plph`

<!-- comment on view pr.plph is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.plph.id is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.plph.productid is @until-end-tag; --><!-- end --> |
| `startdate` | `timestamp without time zone` | <!-- comment on column pr.plph.startdate is @until-end-tag; --><!-- end --> |
| `enddate` | `timestamp without time zone` | <!-- comment on column pr.plph.enddate is @until-end-tag; --><!-- end --> |
| `listprice` | `numeric` | <!-- comment on column pr.plph.listprice is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.plph.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pm`

<!-- comment on view pr.pm is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.pm.id is @until-end-tag; --><!-- end --> |
| `productmodelid` | `integer` | <!-- comment on column pr.pm.productmodelid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pr.pm.name is @until-end-tag; --><!-- end --> |
| `catalogdescription` | `xml` | <!-- comment on column pr.pm.catalogdescription is @until-end-tag; --><!-- end --> |
| `instructions` | `xml` | <!-- comment on column pr.pm.instructions is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pr.pm.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pm.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pmi`

<!-- comment on view pr.pmi is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `productmodelid` | `integer` | <!-- comment on column pr.pmi.productmodelid is @until-end-tag; --><!-- end --> |
| `illustrationid` | `integer` | <!-- comment on column pr.pmi.illustrationid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pmi.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pmpdc`

<!-- comment on view pr.pmpdc is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `productmodelid` | `integer` | <!-- comment on column pr.pmpdc.productmodelid is @until-end-tag; --><!-- end --> |
| `productdescriptionid` | `integer` | <!-- comment on column pr.pmpdc.productdescriptionid is @until-end-tag; --><!-- end --> |
| `cultureid` | `character(6)` | <!-- comment on column pr.pmpdc.cultureid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pmpdc.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pp`

<!-- comment on view pr.pp is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.pp.id is @until-end-tag; --><!-- end --> |
| `productphotoid` | `integer` | <!-- comment on column pr.pp.productphotoid is @until-end-tag; --><!-- end --> |
| `thumbnailphoto` | `bytea` | <!-- comment on column pr.pp.thumbnailphoto is @until-end-tag; --><!-- end --> |
| `thumbnailphotofilename` | `character varying(50)` | <!-- comment on column pr.pp.thumbnailphotofilename is @until-end-tag; --><!-- end --> |
| `largephoto` | `bytea` | <!-- comment on column pr.pp.largephoto is @until-end-tag; --><!-- end --> |
| `largephotofilename` | `character varying(50)` | <!-- comment on column pr.pp.largephotofilename is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pp.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.ppp`

<!-- comment on view pr.ppp is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `productid` | `integer` | <!-- comment on column pr.ppp.productid is @until-end-tag; --><!-- end --> |
| `productphotoid` | `integer` | <!-- comment on column pr.ppp.productphotoid is @until-end-tag; --><!-- end --> |
| `primary` | `boolean` | <!-- comment on column pr.ppp.primary is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.ppp.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.pr`

<!-- comment on view pr.pr is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.pr.id is @until-end-tag; --><!-- end --> |
| `productreviewid` | `integer` | <!-- comment on column pr.pr.productreviewid is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.pr.productid is @until-end-tag; --><!-- end --> |
| `reviewername` | `character varying(50)` | <!-- comment on column pr.pr.reviewername is @until-end-tag; --><!-- end --> |
| `reviewdate` | `timestamp without time zone` | <!-- comment on column pr.pr.reviewdate is @until-end-tag; --><!-- end --> |
| `emailaddress` | `character varying(50)` | <!-- comment on column pr.pr.emailaddress is @until-end-tag; --><!-- end --> |
| `rating` | `integer` | <!-- comment on column pr.pr.rating is @until-end-tag; --><!-- end --> |
| `comments` | `character varying(3850)` | <!-- comment on column pr.pr.comments is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.pr.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.psc`

<!-- comment on view pr.psc is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.psc.id is @until-end-tag; --><!-- end --> |
| `productsubcategoryid` | `integer` | <!-- comment on column pr.psc.productsubcategoryid is @until-end-tag; --><!-- end --> |
| `productcategoryid` | `integer` | <!-- comment on column pr.psc.productcategoryid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pr.psc.name is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pr.psc.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.psc.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.sr`

<!-- comment on view pr.sr is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.sr.id is @until-end-tag; --><!-- end --> |
| `scrapreasonid` | `integer` | <!-- comment on column pr.sr.scrapreasonid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pr.sr.name is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.sr.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.th`

<!-- comment on view pr.th is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.th.id is @until-end-tag; --><!-- end --> |
| `transactionid` | `integer` | <!-- comment on column pr.th.transactionid is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.th.productid is @until-end-tag; --><!-- end --> |
| `referenceorderid` | `integer` | <!-- comment on column pr.th.referenceorderid is @until-end-tag; --><!-- end --> |
| `referenceorderlineid` | `integer` | <!-- comment on column pr.th.referenceorderlineid is @until-end-tag; --><!-- end --> |
| `transactiondate` | `timestamp without time zone` | <!-- comment on column pr.th.transactiondate is @until-end-tag; --><!-- end --> |
| `transactiontype` | `character(1)` | <!-- comment on column pr.th.transactiontype is @until-end-tag; --><!-- end --> |
| `quantity` | `integer` | <!-- comment on column pr.th.quantity is @until-end-tag; --><!-- end --> |
| `actualcost` | `numeric` | <!-- comment on column pr.th.actualcost is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.th.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.tha`

<!-- comment on view pr.tha is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.tha.id is @until-end-tag; --><!-- end --> |
| `transactionid` | `integer` | <!-- comment on column pr.tha.transactionid is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.tha.productid is @until-end-tag; --><!-- end --> |
| `referenceorderid` | `integer` | <!-- comment on column pr.tha.referenceorderid is @until-end-tag; --><!-- end --> |
| `referenceorderlineid` | `integer` | <!-- comment on column pr.tha.referenceorderlineid is @until-end-tag; --><!-- end --> |
| `transactiondate` | `timestamp without time zone` | <!-- comment on column pr.tha.transactiondate is @until-end-tag; --><!-- end --> |
| `transactiontype` | `character(1)` | <!-- comment on column pr.tha.transactiontype is @until-end-tag; --><!-- end --> |
| `quantity` | `integer` | <!-- comment on column pr.tha.quantity is @until-end-tag; --><!-- end --> |
| `actualcost` | `numeric` | <!-- comment on column pr.tha.actualcost is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.tha.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.um`

<!-- comment on view pr.um is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `character(3)` | <!-- comment on column pr.um.id is @until-end-tag; --><!-- end --> |
| `unitmeasurecode` | `character(3)` | <!-- comment on column pr.um.unitmeasurecode is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pr.um.name is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.um.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.w`

<!-- comment on view pr.w is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.w.id is @until-end-tag; --><!-- end --> |
| `workorderid` | `integer` | <!-- comment on column pr.w.workorderid is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.w.productid is @until-end-tag; --><!-- end --> |
| `orderqty` | `integer` | <!-- comment on column pr.w.orderqty is @until-end-tag; --><!-- end --> |
| `scrappedqty` | `smallint` | <!-- comment on column pr.w.scrappedqty is @until-end-tag; --><!-- end --> |
| `startdate` | `timestamp without time zone` | <!-- comment on column pr.w.startdate is @until-end-tag; --><!-- end --> |
| `enddate` | `timestamp without time zone` | <!-- comment on column pr.w.enddate is @until-end-tag; --><!-- end --> |
| `duedate` | `timestamp without time zone` | <!-- comment on column pr.w.duedate is @until-end-tag; --><!-- end --> |
| `scrapreasonid` | `smallint` | <!-- comment on column pr.w.scrapreasonid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.w.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pr.wr`

<!-- comment on view pr.wr is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pr.wr.id is @until-end-tag; --><!-- end --> |
| `workorderid` | `integer` | <!-- comment on column pr.wr.workorderid is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pr.wr.productid is @until-end-tag; --><!-- end --> |
| `operationsequence` | `smallint` | <!-- comment on column pr.wr.operationsequence is @until-end-tag; --><!-- end --> |
| `locationid` | `smallint` | <!-- comment on column pr.wr.locationid is @until-end-tag; --><!-- end --> |
| `scheduledstartdate` | `timestamp without time zone` | <!-- comment on column pr.wr.scheduledstartdate is @until-end-tag; --><!-- end --> |
| `scheduledenddate` | `timestamp without time zone` | <!-- comment on column pr.wr.scheduledenddate is @until-end-tag; --><!-- end --> |
| `actualstartdate` | `timestamp without time zone` | <!-- comment on column pr.wr.actualstartdate is @until-end-tag; --><!-- end --> |
| `actualenddate` | `timestamp without time zone` | <!-- comment on column pr.wr.actualenddate is @until-end-tag; --><!-- end --> |
| `actualresourcehrs` | `numeric(9,10),4)` | <!-- comment on column pr.wr.actualresourcehrs is @until-end-tag; --><!-- end --> |
| `plannedcost` | `numeric` | <!-- comment on column pr.wr.plannedcost is @until-end-tag; --><!-- end --> |
| `actualcost` | `numeric` | <!-- comment on column pr.wr.actualcost is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pr.wr.modifieddate is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `production.vproductmodelcatalogdescription`

<!-- comment on view production.vproductmodelcatalogdescription is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `productmodelid` | `integer` | <!-- comment on column production.vproductmodelcatalogdescription.productmodelid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column production.vproductmodelcatalogdescription.name is @until-end-tag; --><!-- end --> |
| `Summary` | `character varying` | <!-- comment on column production.vproductmodelcatalogdescription.Summary is @until-end-tag; --><!-- end --> |
| `manufacturer` | `character varying` | <!-- comment on column production.vproductmodelcatalogdescription.manufacturer is @until-end-tag; --><!-- end --> |
| `copyright` | `character varying(30)` | <!-- comment on column production.vproductmodelcatalogdescription.copyright is @until-end-tag; --><!-- end --> |
| `producturl` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.producturl is @until-end-tag; --><!-- end --> |
| `warrantyperiod` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.warrantyperiod is @until-end-tag; --><!-- end --> |
| `warrantydescription` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.warrantydescription is @until-end-tag; --><!-- end --> |
| `noofyears` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.noofyears is @until-end-tag; --><!-- end --> |
| `maintenancedescription` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.maintenancedescription is @until-end-tag; --><!-- end --> |
| `wheel` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.wheel is @until-end-tag; --><!-- end --> |
| `saddle` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.saddle is @until-end-tag; --><!-- end --> |
| `pedal` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.pedal is @until-end-tag; --><!-- end --> |
| `bikeframe` | `character varying` | <!-- comment on column production.vproductmodelcatalogdescription.bikeframe is @until-end-tag; --><!-- end --> |
| `crankset` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.crankset is @until-end-tag; --><!-- end --> |
| `pictureangle` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.pictureangle is @until-end-tag; --><!-- end --> |
| `picturesize` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.picturesize is @until-end-tag; --><!-- end --> |
| `productphotoid` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.productphotoid is @until-end-tag; --><!-- end --> |
| `material` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.material is @until-end-tag; --><!-- end --> |
| `color` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.color is @until-end-tag; --><!-- end --> |
| `productline` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.productline is @until-end-tag; --><!-- end --> |
| `style` | `character varying(256)` | <!-- comment on column production.vproductmodelcatalogdescription.style is @until-end-tag; --><!-- end --> |
| `riderexperience` | `character varying(1024)` | <!-- comment on column production.vproductmodelcatalogdescription.riderexperience is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column production.vproductmodelcatalogdescription.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column production.vproductmodelcatalogdescription.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `production.vproductmodelinstructions`

<!-- comment on view production.vproductmodelinstructions is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `productmodelid` | `integer` | <!-- comment on column production.vproductmodelinstructions.productmodelid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column production.vproductmodelinstructions.name is @until-end-tag; --><!-- end --> |
| `instructions` | `character varying` | <!-- comment on column production.vproductmodelinstructions.instructions is @until-end-tag; --><!-- end --> |
| `LocationID` | `integer` | <!-- comment on column production.vproductmodelinstructions.LocationID is @until-end-tag; --><!-- end --> |
| `SetupHours` | `numeric(9,10),4)` | <!-- comment on column production.vproductmodelinstructions.SetupHours is @until-end-tag; --><!-- end --> |
| `MachineHours` | `numeric(9,10),4)` | <!-- comment on column production.vproductmodelinstructions.MachineHours is @until-end-tag; --><!-- end --> |
| `LaborHours` | `numeric(9,10),4)` | <!-- comment on column production.vproductmodelinstructions.LaborHours is @until-end-tag; --><!-- end --> |
| `LotSize` | `integer` | <!-- comment on column production.vproductmodelinstructions.LotSize is @until-end-tag; --><!-- end --> |
| `Step` | `character varying(1024)` | <!-- comment on column production.vproductmodelinstructions.Step is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column production.vproductmodelinstructions.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column production.vproductmodelinstructions.modifieddate is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pu.pod`

<!-- comment on view pu.pod is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pu.pod.id is @until-end-tag; --><!-- end --> |
| `purchaseorderid` | `integer` | <!-- comment on column pu.pod.purchaseorderid is @until-end-tag; --><!-- end --> |
| `purchaseorderdetailid` | `integer` | <!-- comment on column pu.pod.purchaseorderdetailid is @until-end-tag; --><!-- end --> |
| `duedate` | `timestamp without time zone` | <!-- comment on column pu.pod.duedate is @until-end-tag; --><!-- end --> |
| `orderqty` | `smallint` | <!-- comment on column pu.pod.orderqty is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pu.pod.productid is @until-end-tag; --><!-- end --> |
| `unitprice` | `numeric` | <!-- comment on column pu.pod.unitprice is @until-end-tag; --><!-- end --> |
| `receivedqty` | `numeric(8,10),2)` | <!-- comment on column pu.pod.receivedqty is @until-end-tag; --><!-- end --> |
| `rejectedqty` | `numeric(8,10),2)` | <!-- comment on column pu.pod.rejectedqty is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pu.pod.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pu.poh`

<!-- comment on view pu.poh is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pu.poh.id is @until-end-tag; --><!-- end --> |
| `purchaseorderid` | `integer` | <!-- comment on column pu.poh.purchaseorderid is @until-end-tag; --><!-- end --> |
| `revisionnumber` | `smallint` | <!-- comment on column pu.poh.revisionnumber is @until-end-tag; --><!-- end --> |
| `status` | `smallint` | <!-- comment on column pu.poh.status is @until-end-tag; --><!-- end --> |
| `employeeid` | `integer` | <!-- comment on column pu.poh.employeeid is @until-end-tag; --><!-- end --> |
| `vendorid` | `integer` | <!-- comment on column pu.poh.vendorid is @until-end-tag; --><!-- end --> |
| `shipmethodid` | `integer` | <!-- comment on column pu.poh.shipmethodid is @until-end-tag; --><!-- end --> |
| `orderdate` | `timestamp without time zone` | <!-- comment on column pu.poh.orderdate is @until-end-tag; --><!-- end --> |
| `shipdate` | `timestamp without time zone` | <!-- comment on column pu.poh.shipdate is @until-end-tag; --><!-- end --> |
| `subtotal` | `numeric` | <!-- comment on column pu.poh.subtotal is @until-end-tag; --><!-- end --> |
| `taxamt` | `numeric` | <!-- comment on column pu.poh.taxamt is @until-end-tag; --><!-- end --> |
| `freight` | `numeric` | <!-- comment on column pu.poh.freight is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pu.poh.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pu.pv`

<!-- comment on view pu.pv is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pu.pv.id is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column pu.pv.productid is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pu.pv.businessentityid is @until-end-tag; --><!-- end --> |
| `averageleadtime` | `integer` | <!-- comment on column pu.pv.averageleadtime is @until-end-tag; --><!-- end --> |
| `standardprice` | `numeric` | <!-- comment on column pu.pv.standardprice is @until-end-tag; --><!-- end --> |
| `lastreceiptcost` | `numeric` | <!-- comment on column pu.pv.lastreceiptcost is @until-end-tag; --><!-- end --> |
| `lastreceiptdate` | `timestamp without time zone` | <!-- comment on column pu.pv.lastreceiptdate is @until-end-tag; --><!-- end --> |
| `minorderqty` | `integer` | <!-- comment on column pu.pv.minorderqty is @until-end-tag; --><!-- end --> |
| `maxorderqty` | `integer` | <!-- comment on column pu.pv.maxorderqty is @until-end-tag; --><!-- end --> |
| `onorderqty` | `integer` | <!-- comment on column pu.pv.onorderqty is @until-end-tag; --><!-- end --> |
| `unitmeasurecode` | `character(3)` | <!-- comment on column pu.pv.unitmeasurecode is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pu.pv.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pu.sm`

<!-- comment on view pu.sm is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pu.sm.id is @until-end-tag; --><!-- end --> |
| `shipmethodid` | `integer` | <!-- comment on column pu.sm.shipmethodid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pu.sm.name is @until-end-tag; --><!-- end --> |
| `shipbase` | `numeric` | <!-- comment on column pu.sm.shipbase is @until-end-tag; --><!-- end --> |
| `shiprate` | `numeric` | <!-- comment on column pu.sm.shiprate is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column pu.sm.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pu.sm.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `pu.v`

<!-- comment on view pu.v is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column pu.v.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column pu.v.businessentityid is @until-end-tag; --><!-- end --> |
| `accountnumber` | `character varying(15)` | <!-- comment on column pu.v.accountnumber is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column pu.v.name is @until-end-tag; --><!-- end --> |
| `creditrating` | `smallint` | <!-- comment on column pu.v.creditrating is @until-end-tag; --><!-- end --> |
| `preferredvendorstatus` | `boolean` | <!-- comment on column pu.v.preferredvendorstatus is @until-end-tag; --><!-- end --> |
| `activeflag` | `boolean` | <!-- comment on column pu.v.activeflag is @until-end-tag; --><!-- end --> |
| `purchasingwebserviceurl` | `character varying(1024)` | <!-- comment on column pu.v.purchasingwebserviceurl is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column pu.v.modifieddate is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `purchasing.vvendorwithaddresses`

<!-- comment on view purchasing.vvendorwithaddresses is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column purchasing.vvendorwithaddresses.businessentityid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithaddresses.name is @until-end-tag; --><!-- end --> |
| `addresstype` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithaddresses.addresstype is @until-end-tag; --><!-- end --> |
| `addressline1` | `character varying(60)` | <!-- comment on column purchasing.vvendorwithaddresses.addressline1 is @until-end-tag; --><!-- end --> |
| `addressline2` | `character varying(60)` | <!-- comment on column purchasing.vvendorwithaddresses.addressline2 is @until-end-tag; --><!-- end --> |
| `city` | `character varying(30)` | <!-- comment on column purchasing.vvendorwithaddresses.city is @until-end-tag; --><!-- end --> |
| `stateprovincename` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithaddresses.stateprovincename is @until-end-tag; --><!-- end --> |
| `postalcode` | `character varying(15)` | <!-- comment on column purchasing.vvendorwithaddresses.postalcode is @until-end-tag; --><!-- end --> |
| `countryregionname` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithaddresses.countryregionname is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `purchasing.vvendorwithcontacts`

<!-- comment on view purchasing.vvendorwithcontacts is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column purchasing.vvendorwithcontacts.businessentityid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithcontacts.name is @until-end-tag; --><!-- end --> |
| `contacttype` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithcontacts.contacttype is @until-end-tag; --><!-- end --> |
| `title` | `character varying(8)` | <!-- comment on column purchasing.vvendorwithcontacts.title is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithcontacts.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithcontacts.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithcontacts.lastname is @until-end-tag; --><!-- end --> |
| `suffix` | `character varying(10)` | <!-- comment on column purchasing.vvendorwithcontacts.suffix is @until-end-tag; --><!-- end --> |
| `phonenumber` | `character varying(25)` | <!-- comment on column purchasing.vvendorwithcontacts.phonenumber is @until-end-tag; --><!-- end --> |
| `phonenumbertype` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithcontacts.phonenumbertype is @until-end-tag; --><!-- end --> |
| `emailaddress` | `character varying(50)` | <!-- comment on column purchasing.vvendorwithcontacts.emailaddress is @until-end-tag; --><!-- end --> |
| `emailpromotion` | `integer` | <!-- comment on column purchasing.vvendorwithcontacts.emailpromotion is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.c`

<!-- comment on view sa.c is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.c.id is @until-end-tag; --><!-- end --> |
| `customerid` | `integer` | <!-- comment on column sa.c.customerid is @until-end-tag; --><!-- end --> |
| `personid` | `integer` | <!-- comment on column sa.c.personid is @until-end-tag; --><!-- end --> |
| `storeid` | `integer` | <!-- comment on column sa.c.storeid is @until-end-tag; --><!-- end --> |
| `territoryid` | `integer` | <!-- comment on column sa.c.territoryid is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.c.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.c.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.cc`

<!-- comment on view sa.cc is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.cc.id is @until-end-tag; --><!-- end --> |
| `creditcardid` | `integer` | <!-- comment on column sa.cc.creditcardid is @until-end-tag; --><!-- end --> |
| `cardtype` | `character varying(50)` | <!-- comment on column sa.cc.cardtype is @until-end-tag; --><!-- end --> |
| `cardnumber` | `character varying(25)` | <!-- comment on column sa.cc.cardnumber is @until-end-tag; --><!-- end --> |
| `expmonth` | `smallint` | <!-- comment on column sa.cc.expmonth is @until-end-tag; --><!-- end --> |
| `expyear` | `smallint` | <!-- comment on column sa.cc.expyear is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.cc.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.cr`

<!-- comment on view sa.cr is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `currencyrateid` | `integer` | <!-- comment on column sa.cr.currencyrateid is @until-end-tag; --><!-- end --> |
| `currencyratedate` | `timestamp without time zone` | <!-- comment on column sa.cr.currencyratedate is @until-end-tag; --><!-- end --> |
| `fromcurrencycode` | `character(3)` | <!-- comment on column sa.cr.fromcurrencycode is @until-end-tag; --><!-- end --> |
| `tocurrencycode` | `character(3)` | <!-- comment on column sa.cr.tocurrencycode is @until-end-tag; --><!-- end --> |
| `averagerate` | `numeric` | <!-- comment on column sa.cr.averagerate is @until-end-tag; --><!-- end --> |
| `endofdayrate` | `numeric` | <!-- comment on column sa.cr.endofdayrate is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.cr.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.crc`

<!-- comment on view sa.crc is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `countryregioncode` | `character varying(3)` | <!-- comment on column sa.crc.countryregioncode is @until-end-tag; --><!-- end --> |
| `currencycode` | `character(3)` | <!-- comment on column sa.crc.currencycode is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.crc.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.cu`

<!-- comment on view sa.cu is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `character(3)` | <!-- comment on column sa.cu.id is @until-end-tag; --><!-- end --> |
| `currencycode` | `character(3)` | <!-- comment on column sa.cu.currencycode is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column sa.cu.name is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.cu.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.pcc`

<!-- comment on view sa.pcc is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.pcc.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column sa.pcc.businessentityid is @until-end-tag; --><!-- end --> |
| `creditcardid` | `integer` | <!-- comment on column sa.pcc.creditcardid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.pcc.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.s`

<!-- comment on view sa.s is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.s.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column sa.s.businessentityid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column sa.s.name is @until-end-tag; --><!-- end --> |
| `salespersonid` | `integer` | <!-- comment on column sa.s.salespersonid is @until-end-tag; --><!-- end --> |
| `demographics` | `xml` | <!-- comment on column sa.s.demographics is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.s.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.s.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.sci`

<!-- comment on view sa.sci is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.sci.id is @until-end-tag; --><!-- end --> |
| `shoppingcartitemid` | `integer` | <!-- comment on column sa.sci.shoppingcartitemid is @until-end-tag; --><!-- end --> |
| `shoppingcartid` | `character varying(50)` | <!-- comment on column sa.sci.shoppingcartid is @until-end-tag; --><!-- end --> |
| `quantity` | `integer` | <!-- comment on column sa.sci.quantity is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column sa.sci.productid is @until-end-tag; --><!-- end --> |
| `datecreated` | `timestamp without time zone` | <!-- comment on column sa.sci.datecreated is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.sci.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.so`

<!-- comment on view sa.so is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.so.id is @until-end-tag; --><!-- end --> |
| `specialofferid` | `integer` | <!-- comment on column sa.so.specialofferid is @until-end-tag; --><!-- end --> |
| `description` | `character varying(255)` | <!-- comment on column sa.so.description is @until-end-tag; --><!-- end --> |
| `discountpct` | `numeric` | <!-- comment on column sa.so.discountpct is @until-end-tag; --><!-- end --> |
| `type` | `character varying(50)` | <!-- comment on column sa.so.type is @until-end-tag; --><!-- end --> |
| `category` | `character varying(50)` | <!-- comment on column sa.so.category is @until-end-tag; --><!-- end --> |
| `startdate` | `timestamp without time zone` | <!-- comment on column sa.so.startdate is @until-end-tag; --><!-- end --> |
| `enddate` | `timestamp without time zone` | <!-- comment on column sa.so.enddate is @until-end-tag; --><!-- end --> |
| `minqty` | `integer` | <!-- comment on column sa.so.minqty is @until-end-tag; --><!-- end --> |
| `maxqty` | `integer` | <!-- comment on column sa.so.maxqty is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.so.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.so.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.sod`

<!-- comment on view sa.sod is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.sod.id is @until-end-tag; --><!-- end --> |
| `salesorderid` | `integer` | <!-- comment on column sa.sod.salesorderid is @until-end-tag; --><!-- end --> |
| `salesorderdetailid` | `integer` | <!-- comment on column sa.sod.salesorderdetailid is @until-end-tag; --><!-- end --> |
| `carriertrackingnumber` | `character varying(25)` | <!-- comment on column sa.sod.carriertrackingnumber is @until-end-tag; --><!-- end --> |
| `orderqty` | `smallint` | <!-- comment on column sa.sod.orderqty is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column sa.sod.productid is @until-end-tag; --><!-- end --> |
| `specialofferid` | `integer` | <!-- comment on column sa.sod.specialofferid is @until-end-tag; --><!-- end --> |
| `unitprice` | `numeric` | <!-- comment on column sa.sod.unitprice is @until-end-tag; --><!-- end --> |
| `unitpricediscount` | `numeric` | <!-- comment on column sa.sod.unitpricediscount is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.sod.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.sod.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.soh`

<!-- comment on view sa.soh is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.soh.id is @until-end-tag; --><!-- end --> |
| `salesorderid` | `integer` | <!-- comment on column sa.soh.salesorderid is @until-end-tag; --><!-- end --> |
| `revisionnumber` | `smallint` | <!-- comment on column sa.soh.revisionnumber is @until-end-tag; --><!-- end --> |
| `orderdate` | `timestamp without time zone` | <!-- comment on column sa.soh.orderdate is @until-end-tag; --><!-- end --> |
| `duedate` | `timestamp without time zone` | <!-- comment on column sa.soh.duedate is @until-end-tag; --><!-- end --> |
| `shipdate` | `timestamp without time zone` | <!-- comment on column sa.soh.shipdate is @until-end-tag; --><!-- end --> |
| `status` | `smallint` | <!-- comment on column sa.soh.status is @until-end-tag; --><!-- end --> |
| `onlineorderflag` | `boolean` | <!-- comment on column sa.soh.onlineorderflag is @until-end-tag; --><!-- end --> |
| `purchaseordernumber` | `character varying(25)` | <!-- comment on column sa.soh.purchaseordernumber is @until-end-tag; --><!-- end --> |
| `accountnumber` | `character varying(15)` | <!-- comment on column sa.soh.accountnumber is @until-end-tag; --><!-- end --> |
| `customerid` | `integer` | <!-- comment on column sa.soh.customerid is @until-end-tag; --><!-- end --> |
| `salespersonid` | `integer` | <!-- comment on column sa.soh.salespersonid is @until-end-tag; --><!-- end --> |
| `territoryid` | `integer` | <!-- comment on column sa.soh.territoryid is @until-end-tag; --><!-- end --> |
| `billtoaddressid` | `integer` | <!-- comment on column sa.soh.billtoaddressid is @until-end-tag; --><!-- end --> |
| `shiptoaddressid` | `integer` | <!-- comment on column sa.soh.shiptoaddressid is @until-end-tag; --><!-- end --> |
| `shipmethodid` | `integer` | <!-- comment on column sa.soh.shipmethodid is @until-end-tag; --><!-- end --> |
| `creditcardid` | `integer` | <!-- comment on column sa.soh.creditcardid is @until-end-tag; --><!-- end --> |
| `creditcardapprovalcode` | `character varying(15)` | <!-- comment on column sa.soh.creditcardapprovalcode is @until-end-tag; --><!-- end --> |
| `currencyrateid` | `integer` | <!-- comment on column sa.soh.currencyrateid is @until-end-tag; --><!-- end --> |
| `subtotal` | `numeric` | <!-- comment on column sa.soh.subtotal is @until-end-tag; --><!-- end --> |
| `taxamt` | `numeric` | <!-- comment on column sa.soh.taxamt is @until-end-tag; --><!-- end --> |
| `freight` | `numeric` | <!-- comment on column sa.soh.freight is @until-end-tag; --><!-- end --> |
| `totaldue` | `numeric` | <!-- comment on column sa.soh.totaldue is @until-end-tag; --><!-- end --> |
| `comment` | `character varying(128)` | <!-- comment on column sa.soh.comment is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.soh.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.soh.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.sohsr`

<!-- comment on view sa.sohsr is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `salesorderid` | `integer` | <!-- comment on column sa.sohsr.salesorderid is @until-end-tag; --><!-- end --> |
| `salesreasonid` | `integer` | <!-- comment on column sa.sohsr.salesreasonid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.sohsr.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.sop`

<!-- comment on view sa.sop is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.sop.id is @until-end-tag; --><!-- end --> |
| `specialofferid` | `integer` | <!-- comment on column sa.sop.specialofferid is @until-end-tag; --><!-- end --> |
| `productid` | `integer` | <!-- comment on column sa.sop.productid is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.sop.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.sop.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.sp`

<!-- comment on view sa.sp is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.sp.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column sa.sp.businessentityid is @until-end-tag; --><!-- end --> |
| `territoryid` | `integer` | <!-- comment on column sa.sp.territoryid is @until-end-tag; --><!-- end --> |
| `salesquota` | `numeric` | <!-- comment on column sa.sp.salesquota is @until-end-tag; --><!-- end --> |
| `bonus` | `numeric` | <!-- comment on column sa.sp.bonus is @until-end-tag; --><!-- end --> |
| `commissionpct` | `numeric` | <!-- comment on column sa.sp.commissionpct is @until-end-tag; --><!-- end --> |
| `salesytd` | `numeric` | <!-- comment on column sa.sp.salesytd is @until-end-tag; --><!-- end --> |
| `saleslastyear` | `numeric` | <!-- comment on column sa.sp.saleslastyear is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.sp.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.sp.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.spqh`

<!-- comment on view sa.spqh is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.spqh.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column sa.spqh.businessentityid is @until-end-tag; --><!-- end --> |
| `quotadate` | `timestamp without time zone` | <!-- comment on column sa.spqh.quotadate is @until-end-tag; --><!-- end --> |
| `salesquota` | `numeric` | <!-- comment on column sa.spqh.salesquota is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.spqh.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.spqh.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.sr`

<!-- comment on view sa.sr is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.sr.id is @until-end-tag; --><!-- end --> |
| `salesreasonid` | `integer` | <!-- comment on column sa.sr.salesreasonid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column sa.sr.name is @until-end-tag; --><!-- end --> |
| `reasontype` | `character varying(50)` | <!-- comment on column sa.sr.reasontype is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.sr.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.st`

<!-- comment on view sa.st is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.st.id is @until-end-tag; --><!-- end --> |
| `territoryid` | `integer` | <!-- comment on column sa.st.territoryid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column sa.st.name is @until-end-tag; --><!-- end --> |
| `countryregioncode` | `character varying(3)` | <!-- comment on column sa.st.countryregioncode is @until-end-tag; --><!-- end --> |
| `group` | `character varying(50)` | <!-- comment on column sa.st.group is @until-end-tag; --><!-- end --> |
| `salesytd` | `numeric` | <!-- comment on column sa.st.salesytd is @until-end-tag; --><!-- end --> |
| `saleslastyear` | `numeric` | <!-- comment on column sa.st.saleslastyear is @until-end-tag; --><!-- end --> |
| `costytd` | `numeric` | <!-- comment on column sa.st.costytd is @until-end-tag; --><!-- end --> |
| `costlastyear` | `numeric` | <!-- comment on column sa.st.costlastyear is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.st.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.st.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.sth`

<!-- comment on view sa.sth is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.sth.id is @until-end-tag; --><!-- end --> |
| `businessentityid` | `integer` | <!-- comment on column sa.sth.businessentityid is @until-end-tag; --><!-- end --> |
| `territoryid` | `integer` | <!-- comment on column sa.sth.territoryid is @until-end-tag; --><!-- end --> |
| `startdate` | `timestamp without time zone` | <!-- comment on column sa.sth.startdate is @until-end-tag; --><!-- end --> |
| `enddate` | `timestamp without time zone` | <!-- comment on column sa.sth.enddate is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.sth.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.sth.modifieddate is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sa.tr`

<!-- comment on view sa.tr is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `id` | `integer` | <!-- comment on column sa.tr.id is @until-end-tag; --><!-- end --> |
| `salestaxrateid` | `integer` | <!-- comment on column sa.tr.salestaxrateid is @until-end-tag; --><!-- end --> |
| `stateprovinceid` | `integer` | <!-- comment on column sa.tr.stateprovinceid is @until-end-tag; --><!-- end --> |
| `taxtype` | `smallint` | <!-- comment on column sa.tr.taxtype is @until-end-tag; --><!-- end --> |
| `taxrate` | `numeric` | <!-- comment on column sa.tr.taxrate is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column sa.tr.name is @until-end-tag; --><!-- end --> |
| `rowguid` | `uuid` | <!-- comment on column sa.tr.rowguid is @until-end-tag; --><!-- end --> |
| `modifieddate` | `timestamp without time zone` | <!-- comment on column sa.tr.modifieddate is @until-end-tag; --><!-- end --> |

## Views

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sales.vindividualcustomer`

<!-- comment on view sales.vindividualcustomer is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column sales.vindividualcustomer.businessentityid is @until-end-tag; --><!-- end --> |
| `title` | `character varying(8)` | <!-- comment on column sales.vindividualcustomer.title is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column sales.vindividualcustomer.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column sales.vindividualcustomer.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column sales.vindividualcustomer.lastname is @until-end-tag; --><!-- end --> |
| `suffix` | `character varying(10)` | <!-- comment on column sales.vindividualcustomer.suffix is @until-end-tag; --><!-- end --> |
| `phonenumber` | `character varying(25)` | <!-- comment on column sales.vindividualcustomer.phonenumber is @until-end-tag; --><!-- end --> |
| `phonenumbertype` | `character varying(50)` | <!-- comment on column sales.vindividualcustomer.phonenumbertype is @until-end-tag; --><!-- end --> |
| `emailaddress` | `character varying(50)` | <!-- comment on column sales.vindividualcustomer.emailaddress is @until-end-tag; --><!-- end --> |
| `emailpromotion` | `integer` | <!-- comment on column sales.vindividualcustomer.emailpromotion is @until-end-tag; --><!-- end --> |
| `addresstype` | `character varying(50)` | <!-- comment on column sales.vindividualcustomer.addresstype is @until-end-tag; --><!-- end --> |
| `addressline1` | `character varying(60)` | <!-- comment on column sales.vindividualcustomer.addressline1 is @until-end-tag; --><!-- end --> |
| `addressline2` | `character varying(60)` | <!-- comment on column sales.vindividualcustomer.addressline2 is @until-end-tag; --><!-- end --> |
| `city` | `character varying(30)` | <!-- comment on column sales.vindividualcustomer.city is @until-end-tag; --><!-- end --> |
| `stateprovincename` | `character varying(50)` | <!-- comment on column sales.vindividualcustomer.stateprovincename is @until-end-tag; --><!-- end --> |
| `postalcode` | `character varying(15)` | <!-- comment on column sales.vindividualcustomer.postalcode is @until-end-tag; --><!-- end --> |
| `countryregionname` | `character varying(50)` | <!-- comment on column sales.vindividualcustomer.countryregionname is @until-end-tag; --><!-- end --> |
| `demographics` | `xml` | <!-- comment on column sales.vindividualcustomer.demographics is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sales.vpersondemographics`

<!-- comment on view sales.vpersondemographics is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column sales.vpersondemographics.businessentityid is @until-end-tag; --><!-- end --> |
| `totalpurchaseytd` | `money` | <!-- comment on column sales.vpersondemographics.totalpurchaseytd is @until-end-tag; --><!-- end --> |
| `datefirstpurchase` | `date` | <!-- comment on column sales.vpersondemographics.datefirstpurchase is @until-end-tag; --><!-- end --> |
| `birthdate` | `date` | <!-- comment on column sales.vpersondemographics.birthdate is @until-end-tag; --><!-- end --> |
| `maritalstatus` | `character varying(1)` | <!-- comment on column sales.vpersondemographics.maritalstatus is @until-end-tag; --><!-- end --> |
| `yearlyincome` | `character varying(30)` | <!-- comment on column sales.vpersondemographics.yearlyincome is @until-end-tag; --><!-- end --> |
| `gender` | `character varying(1)` | <!-- comment on column sales.vpersondemographics.gender is @until-end-tag; --><!-- end --> |
| `totalchildren` | `integer` | <!-- comment on column sales.vpersondemographics.totalchildren is @until-end-tag; --><!-- end --> |
| `numberchildrenathome` | `integer` | <!-- comment on column sales.vpersondemographics.numberchildrenathome is @until-end-tag; --><!-- end --> |
| `education` | `character varying(30)` | <!-- comment on column sales.vpersondemographics.education is @until-end-tag; --><!-- end --> |
| `occupation` | `character varying(30)` | <!-- comment on column sales.vpersondemographics.occupation is @until-end-tag; --><!-- end --> |
| `homeownerflag` | `boolean` | <!-- comment on column sales.vpersondemographics.homeownerflag is @until-end-tag; --><!-- end --> |
| `numbercarsowned` | `integer` | <!-- comment on column sales.vpersondemographics.numbercarsowned is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sales.vsalesperson`

<!-- comment on view sales.vsalesperson is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column sales.vsalesperson.businessentityid is @until-end-tag; --><!-- end --> |
| `title` | `character varying(8)` | <!-- comment on column sales.vsalesperson.title is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column sales.vsalesperson.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column sales.vsalesperson.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column sales.vsalesperson.lastname is @until-end-tag; --><!-- end --> |
| `suffix` | `character varying(10)` | <!-- comment on column sales.vsalesperson.suffix is @until-end-tag; --><!-- end --> |
| `jobtitle` | `character varying(50)` | <!-- comment on column sales.vsalesperson.jobtitle is @until-end-tag; --><!-- end --> |
| `phonenumber` | `character varying(25)` | <!-- comment on column sales.vsalesperson.phonenumber is @until-end-tag; --><!-- end --> |
| `phonenumbertype` | `character varying(50)` | <!-- comment on column sales.vsalesperson.phonenumbertype is @until-end-tag; --><!-- end --> |
| `emailaddress` | `character varying(50)` | <!-- comment on column sales.vsalesperson.emailaddress is @until-end-tag; --><!-- end --> |
| `emailpromotion` | `integer` | <!-- comment on column sales.vsalesperson.emailpromotion is @until-end-tag; --><!-- end --> |
| `addressline1` | `character varying(60)` | <!-- comment on column sales.vsalesperson.addressline1 is @until-end-tag; --><!-- end --> |
| `addressline2` | `character varying(60)` | <!-- comment on column sales.vsalesperson.addressline2 is @until-end-tag; --><!-- end --> |
| `city` | `character varying(30)` | <!-- comment on column sales.vsalesperson.city is @until-end-tag; --><!-- end --> |
| `stateprovincename` | `character varying(50)` | <!-- comment on column sales.vsalesperson.stateprovincename is @until-end-tag; --><!-- end --> |
| `postalcode` | `character varying(15)` | <!-- comment on column sales.vsalesperson.postalcode is @until-end-tag; --><!-- end --> |
| `countryregionname` | `character varying(50)` | <!-- comment on column sales.vsalesperson.countryregionname is @until-end-tag; --><!-- end --> |
| `territoryname` | `character varying(50)` | <!-- comment on column sales.vsalesperson.territoryname is @until-end-tag; --><!-- end --> |
| `territorygroup` | `character varying(50)` | <!-- comment on column sales.vsalesperson.territorygroup is @until-end-tag; --><!-- end --> |
| `salesquota` | `numeric` | <!-- comment on column sales.vsalesperson.salesquota is @until-end-tag; --><!-- end --> |
| `salesytd` | `numeric` | <!-- comment on column sales.vsalesperson.salesytd is @until-end-tag; --><!-- end --> |
| `saleslastyear` | `numeric` | <!-- comment on column sales.vsalesperson.saleslastyear is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sales.vsalespersonsalesbyfiscalyears`

<!-- comment on view sales.vsalespersonsalesbyfiscalyears is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `SalesPersonID` | `integer` | <!-- comment on column sales.vsalespersonsalesbyfiscalyears.SalesPersonID is @until-end-tag; --><!-- end --> |
| `FullName` | `text` | <!-- comment on column sales.vsalespersonsalesbyfiscalyears.FullName is @until-end-tag; --><!-- end --> |
| `JobTitle` | `text` | <!-- comment on column sales.vsalespersonsalesbyfiscalyears.JobTitle is @until-end-tag; --><!-- end --> |
| `SalesTerritory` | `text` | <!-- comment on column sales.vsalespersonsalesbyfiscalyears.SalesTerritory is @until-end-tag; --><!-- end --> |
| `2012` | `numeric(12,10),4)` | <!-- comment on column sales.vsalespersonsalesbyfiscalyears.2012 is @until-end-tag; --><!-- end --> |
| `2013` | `numeric(12,10),4)` | <!-- comment on column sales.vsalespersonsalesbyfiscalyears.2013 is @until-end-tag; --><!-- end --> |
| `2014` | `numeric(12,10),4)` | <!-- comment on column sales.vsalespersonsalesbyfiscalyears.2014 is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sales.vsalespersonsalesbyfiscalyearsdata`

<!-- comment on view sales.vsalespersonsalesbyfiscalyearsdata is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `salespersonid` | `integer` | <!-- comment on column sales.vsalespersonsalesbyfiscalyearsdata.salespersonid is @until-end-tag; --><!-- end --> |
| `fullname` | `text` | <!-- comment on column sales.vsalespersonsalesbyfiscalyearsdata.fullname is @until-end-tag; --><!-- end --> |
| `jobtitle` | `character varying(50)` | <!-- comment on column sales.vsalespersonsalesbyfiscalyearsdata.jobtitle is @until-end-tag; --><!-- end --> |
| `salesterritory` | `character varying(50)` | <!-- comment on column sales.vsalespersonsalesbyfiscalyearsdata.salesterritory is @until-end-tag; --><!-- end --> |
| `salestotal` | `numeric` | <!-- comment on column sales.vsalespersonsalesbyfiscalyearsdata.salestotal is @until-end-tag; --><!-- end --> |
| `fiscalyear` | `double precision(53,2)` | <!-- comment on column sales.vsalespersonsalesbyfiscalyearsdata.fiscalyear is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sales.vstorewithaddresses`

<!-- comment on view sales.vstorewithaddresses is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column sales.vstorewithaddresses.businessentityid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column sales.vstorewithaddresses.name is @until-end-tag; --><!-- end --> |
| `addresstype` | `character varying(50)` | <!-- comment on column sales.vstorewithaddresses.addresstype is @until-end-tag; --><!-- end --> |
| `addressline1` | `character varying(60)` | <!-- comment on column sales.vstorewithaddresses.addressline1 is @until-end-tag; --><!-- end --> |
| `addressline2` | `character varying(60)` | <!-- comment on column sales.vstorewithaddresses.addressline2 is @until-end-tag; --><!-- end --> |
| `city` | `character varying(30)` | <!-- comment on column sales.vstorewithaddresses.city is @until-end-tag; --><!-- end --> |
| `stateprovincename` | `character varying(50)` | <!-- comment on column sales.vstorewithaddresses.stateprovincename is @until-end-tag; --><!-- end --> |
| `postalcode` | `character varying(15)` | <!-- comment on column sales.vstorewithaddresses.postalcode is @until-end-tag; --><!-- end --> |
| `countryregionname` | `character varying(50)` | <!-- comment on column sales.vstorewithaddresses.countryregionname is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sales.vstorewithcontacts`

<!-- comment on view sales.vstorewithcontacts is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column sales.vstorewithcontacts.businessentityid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column sales.vstorewithcontacts.name is @until-end-tag; --><!-- end --> |
| `contacttype` | `character varying(50)` | <!-- comment on column sales.vstorewithcontacts.contacttype is @until-end-tag; --><!-- end --> |
| `title` | `character varying(8)` | <!-- comment on column sales.vstorewithcontacts.title is @until-end-tag; --><!-- end --> |
| `firstname` | `character varying(50)` | <!-- comment on column sales.vstorewithcontacts.firstname is @until-end-tag; --><!-- end --> |
| `middlename` | `character varying(50)` | <!-- comment on column sales.vstorewithcontacts.middlename is @until-end-tag; --><!-- end --> |
| `lastname` | `character varying(50)` | <!-- comment on column sales.vstorewithcontacts.lastname is @until-end-tag; --><!-- end --> |
| `suffix` | `character varying(10)` | <!-- comment on column sales.vstorewithcontacts.suffix is @until-end-tag; --><!-- end --> |
| `phonenumber` | `character varying(25)` | <!-- comment on column sales.vstorewithcontacts.phonenumber is @until-end-tag; --><!-- end --> |
| `phonenumbertype` | `character varying(50)` | <!-- comment on column sales.vstorewithcontacts.phonenumbertype is @until-end-tag; --><!-- end --> |
| `emailaddress` | `character varying(50)` | <!-- comment on column sales.vstorewithcontacts.emailaddress is @until-end-tag; --><!-- end --> |
| `emailpromotion` | `integer` | <!-- comment on column sales.vstorewithcontacts.emailpromotion is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### View `sales.vstorewithdemographics`

<!-- comment on view sales.vstorewithdemographics is @until-end-tag; -->
<!-- end -->

| Column | Type | Comment |
| ------ | ---- | --------|
| `businessentityid` | `integer` | <!-- comment on column sales.vstorewithdemographics.businessentityid is @until-end-tag; --><!-- end --> |
| `name` | `character varying(50)` | <!-- comment on column sales.vstorewithdemographics.name is @until-end-tag; --><!-- end --> |
| `AnnualSales` | `money` | <!-- comment on column sales.vstorewithdemographics.AnnualSales is @until-end-tag; --><!-- end --> |
| `AnnualRevenue` | `money` | <!-- comment on column sales.vstorewithdemographics.AnnualRevenue is @until-end-tag; --><!-- end --> |
| `BankName` | `character varying(50)` | <!-- comment on column sales.vstorewithdemographics.BankName is @until-end-tag; --><!-- end --> |
| `BusinessType` | `character varying(5)` | <!-- comment on column sales.vstorewithdemographics.BusinessType is @until-end-tag; --><!-- end --> |
| `YearOpened` | `integer` | <!-- comment on column sales.vstorewithdemographics.YearOpened is @until-end-tag; --><!-- end --> |
| `Specialty` | `character varying(50)` | <!-- comment on column sales.vstorewithdemographics.Specialty is @until-end-tag; --><!-- end --> |
| `SquareFeet` | `integer` | <!-- comment on column sales.vstorewithdemographics.SquareFeet is @until-end-tag; --><!-- end --> |
| `Brands` | `character varying(30)` | <!-- comment on column sales.vstorewithdemographics.Brands is @until-end-tag; --><!-- end --> |
| `Internet` | `character varying(30)` | <!-- comment on column sales.vstorewithdemographics.Internet is @until-end-tag; --><!-- end --> |
| `NumberEmployees` | `integer` | <!-- comment on column sales.vstorewithdemographics.NumberEmployees is @until-end-tag; --><!-- end --> |

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

## Routines

### Function `public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer, text, text, text, text)`

- Returns `record`

- Language is `c`

<!-- comment on function public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer, text, text, text, text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer)`

- Returns `record`

- Language is `c`

<!-- comment on function public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer, text, text, text, text)`

- Returns `record`

- Language is `c`

<!-- comment on function public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer, text, text, text, text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer)`

- Returns `record`

- Language is `c`

<!-- comment on function public.connectby(text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, text, integer, integer, integer, integer) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.crosstab2(text)`

- Returns `setof tablefunc_crosstab_2`

- Language is `c`

<!-- comment on function public.crosstab2(text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.crosstab3(text)`

- Returns `setof tablefunc_crosstab_3`

- Language is `c`

<!-- comment on function public.crosstab3(text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.crosstab4(text)`

- Returns `setof tablefunc_crosstab_4`

- Language is `c`

<!-- comment on function public.crosstab4(text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.crosstab(text, text, text)`

- Returns `record`

- Language is `c`

<!-- comment on function public.crosstab(text, text, text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.crosstab(text, text, text, integer, integer, integer)`

- Returns `record`

- Language is `c`

<!-- comment on function public.crosstab(text, text, text, integer, integer, integer) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.crosstab(text, text, text, text, text, text)`

- Returns `record`

- Language is `c`

<!-- comment on function public.crosstab(text, text, text, text, text, text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.normal_rand(integer, double precision, double precision)`

- Returns `double precision`

- Language is `c`

<!-- comment on function public.normal_rand(integer, double precision, double precision) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_generate_v1()`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_generate_v1() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_generate_v1mc()`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_generate_v1mc() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_generate_v3(uuid, text)`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_generate_v3(uuid, text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_generate_v4()`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_generate_v4() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_generate_v5(uuid, text)`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_generate_v5(uuid, text) is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_nil()`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_nil() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_ns_dns()`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_ns_dns() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_ns_oid()`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_ns_oid() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_ns_url()`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_ns_url() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

### Function `public.uuid_ns_x500()`

- Returns `uuid`

- Language is `c`

<!-- comment on function public.uuid_ns_x500() is @until-end-tag; -->
<!-- end -->

<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

