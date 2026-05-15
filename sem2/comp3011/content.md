# Lecture 1: Introduction
## 1. Module Overview
This module covers three distinct yet interrelated topics: **Web Services**, **Search Engines**, and **Linked Data**.

## 2. Web Services
### 2.1 What is a Web Service?
> A **web service** is a service provided by one machine (the **service provider**) to other machines (the **service requesters**) on the web.

**Why we need them**: To build software systems with **components (modules) distributed across the web**. Rather than building everything from scratch, web services enable the **reuse of existing solutions**.

**Example**: An airline website needs live currency exchange rates. Rather than maintaining its own exchange rate database, it sends a **request** to a financial services website and receives a **response** containing the exchange rate data. The airline site is the **service requester**; the financial services site is the **service provider**.

### 2.2 Advantages of Web Services
* Enables the creation of **complex applications** whose components are hosted on various machines over the web.
* Enables the **reuse** of existing solutions rather than building everything from scratch.
* Web services opened the door for creating **mashups** exhibiting complex functionality.

### 2.3 Mashups
> A **mashup** is a software application (e.g. a web application) that uses content from **more than one source** to create a **single new service**.

**Example**: A flight aggregator (like Skyscanner or Google Flights) combines data from airlines (schedules, prices), hotels (accommodation), car rentals (transportation), and maps (route visualisation) into **one unified interface**.

### 2.4 Web Service Paradigms
Three paradigms facilitate **machine-to-machine communication** in distributed web applications:
* **SOAP-based** web services
* **RESTful** web services
* Other, more recent protocols such as **GraphQL**

## 3. SOAP (Simple Object Access Protocol)
> **SOAP** is an **XML-based protocol** for web services, originating in the year **2000**. It was developed by companies like **Microsoft** and **IBM** for **enterprise applications**.

The SOAP protocol defines: how to **request data**, **message parameters**, **data structures**, and **error messages**.

### 3.1 SOAP Architecture (Three Components)
The SOAP ecosystem involves three key technologies:
* **WSDL (Web Services Description Language)**: Describes the service interface (what operations are available, what data they accept/return).
* **UDDI (Universal Description, Discovery and Integration)**: A registry that allows for the **publishing and discovery** of information about web services.
* **SOAP**: The protocol that processes the request and sends data between the **service requester** and **service provider**.

### 3.2 SOAP Status Today
SOAP is now considered a **legacy system**. Major providers are phasing out support. However, SOAP can still be preferred when **higher levels of security** are required.

## 4. REST (Representational State Transfer)
> **REST** is an **architectural style** (not a protocol). It uses **existing web protocols** such as **HTTP**.

**Exam trap (2020 Q1.1)**: REST stands for **Representational State Transfer**, NOT "Representational State Transitions." This is **False** if stated as "Transitions."

### 4.1 RESTful Standards
> There is **no official standard** for RESTful Web APIs.

However, RESTful implementations make use of **existing internet standards** such as the standards for **HTTP**, **URIs**, **JSON**, and **XML**.

**Exam note (2019 Q1n)**: The statement "There is no official standard for RESTful Web APIs" is **True**.

## 5. SOAP vs REST Comparison

| Aspect | **SOAP** | **REST** |
|---|---|---|
| **Type** | A **protocol** | An **architectural style** |
| **Standards** | Defines **strict standards** to follow | Does **not** define strict standards |
| **Bandwidth** | Requires **more** bandwidth and resources | Requires **less** bandwidth and resources |
| **Security** | Defines **its own security** | **Inherits** security from the underlying transport layer |
| **Data formats** | **XML only** | Plain text, HTML, XML, **JSON**, etc. |
| **State** | Can support **stateful** implementations | Follows the **stateless** model |
| **Caching** | SOAP-based reads **cannot be cached** | REST reads **can be cached** |
| **Scalability** | Can be **difficult to scale** | Better **performance and scalability** |
| **Parsing** | XML is **more difficult to parse** | JSON **parses much faster** than XML |
| **Summary** | **COMPLEX** | **SIMPLE** |

**Exam trap (2020 Q1.2)**: "SOAP-based reads cannot be cached" — **True**.

**When to use SOAP**: When higher levels of security are required (e.g. banking, enterprise).
**When to use REST**: The majority of services available today; REST has effectively **won** the debate.

## 6. Search Engines
### 6.1 What is a Search Engine?
> A **web search engine** is a software system designed to search for information on the **World Wide Web**. Unlike **web directories** (maintained by human editors), search engines obtain **real-time data** by continuously running a **web crawler**.

### 6.2 Three Core Processes
A search engine maintains three processes in **near real time**:
1. **Web Crawling**: The process of moving from one web page to another (like a **spider**), following **hyperlinks** in each page to discover other pages.
2. **Indexing**: Associating **words** found on web pages to their **URLs** and **HTML-based fields** (e.g. title, headings, body).
3. **Searching**: When a user enters a query, the **index** already has the URLs containing the keywords, which are instantly obtained. The real processing load is in **generating the ranked list** of search results.

### 6.3 The Deep Web (Invisible/Hidden Web)
> The **deep web** (also called the **invisible** or **hidden web**) is the part of the WWW that **cannot be seen by search engines**.

Its content is hidden behind: **HTML forms**, web mail, online banking services, paid services, services protected by a **paywall** (e.g. video on demand, some online magazines/newspapers).

Deep web content can only be located and accessed by a **direct URL or IP address**, and may require a password or other security protection.

**Exam trap (2020 Q1.12)**: "The invisible web forms a very small part of the entire world wide web" — **False**. The deep web is estimated to be **several orders of magnitude larger** than the surface web (iceberg analogy).

## 7. Linked Data
### 7.1 Traditional WWW Limitations
The traditional WWW is a collection of **linked documents** that have **little, if any, structure** imposed on the data (mostly images and free text). Data is available in many formats: HTML, XML, PDF, TIFF, CSV, Excel spreadsheets, etc.

**Key limitation**: The traditional web is formatted for **human consumption**. It is **not easy for automated processes** to access, search, or reuse this data.

### 7.2 What is Linked Data?
> **Linked Data** refers to a set of techniques for **publishing and connecting structured data** on the Web.

It solves the traditional web's limitation by making data **machine-readable** and **interlinked** using standards like **RDF** (Resource Description Framework).

**Exam note (2020 Q1.13)**: "Linked Data refers to a set of techniques for publishing and connecting structured data on the Web" — **True**.

## 8. Django (Implementation Framework)
> **Django** is a free **open-source web framework**, written in **Python**.

* The **Django REST Framework** is an extension to Django that specifically supports building **RESTful APIs**.
* In the exam scenario questions (e.g. 2019 Q5), you may be asked to write **pseudocode for a view function** (handler function) using Django-style conventions.

## 9. Past Paper Traps for Lecture 1

| Statement                                                                    | Answer    | Reason                                                                             |
| ---------------------------------------------------------------------------- | --------- | ---------------------------------------------------------------------------------- |
| "REST stands for Representational State **Transitions**"                     | **False** | It is Representational State **Transfer**                                          |
| "There is no official standard for RESTful Web APIs"                         | **True**  | REST uses existing standards (HTTP, URI, JSON, XML) but has no standard of its own |
| "SOAP based reads cannot be cached"                                          | **True**  | Only REST reads (via HTTP GET) can be cached                                       |
| "The invisible web forms a very small part of the entire WWW"                | **False** | The deep web is **several orders of magnitude larger** than the surface web        |
| "Linked Data refers to publishing and connecting structured data on the Web" | **True**  | This is the definition from the lectures                                           |
| SOAP uses which data format?                                                 | **XML**   | SOAP permits **XML only**; REST permits multiple formats                           |