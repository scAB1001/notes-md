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
# Lecture 2: HTTP – The Workhorse of the Web
## 1. What is HTTP?
> **HTTP (HyperText Transfer Protocol)** is the set of rules that allows **web browsers** and **web servers** to talk to each other. It is an **application layer protocol**, meaning it sits on top of all other network layers.

HTTP was first drafted by **Tim Berners-Lee** in **1991** and has evolved from **HTTP/0.9 to HTTP/3**, improving performance and reliability while preserving the same **request–response semantics**.

HTTP uses a **client-server model**: requests are **always initiated by the client**. The client sends an **HTTP request**; the server sends back an **HTTP response**.

## 2. Web Resources and URIs
> A **web resource** is the source of web content. The simplest kind is a **static file** (e.g. an image, text file). Resources can also be **software programs** that generate content on demand (e.g. a stock trading gateway, a search engine).

Each resource is given a unique identifier called a **Uniform Resource Identifier (URI)**.

### 2.1 URL (Uniform Resource Locator)
To access a web resource, you need a **URL**. A URL has three parts:
* **Scheme** (how) — e.g. `http://`
* **Host** (where) — e.g. `www.joes-hardware.com`
* **Path** (what) — e.g. `/seasonal/index-fall.html`

**Exam trap (2019 Q1i)**: "A URL is not the same as a URI" — **True**. A **URL** is a *type* of URI that specifies the location. A **URI** is the broader concept (it identifies a resource; a URL locates it). Every URL is a URI, but not every URI is a URL.

**Exam trap (2020 Q2.5)**: "Anything that has a URL is a resource" — **True**.

## 3. HTTP Message Structure
Both **request** and **response** messages share the same basic structure:
1. A **start line**
2. A block of **headers**
3. An **optional body** (entity body)
### 3.1 Request Message Format
```html
<method> <request-URL> <version>
<headers>

<entity-body>
```
* **Method**: The action to perform (e.g. `GET`, `HEAD`, `POST`)
* **Request-URL**: A complete URL or the **path component** of the resource
* **Version**: The HTTP version, e.g. `HTTP/1.1`
* **Headers**: Zero or more headers, each formatted as `Name: value`
* **Entity-body**: A block of arbitrary data (not all messages have one)

**Example**: `GET /test/hi-there.txt HTTP/1.1`
### 3.2 Response Message Format
```html
<version> <status> <reason-phrase>
<headers>

<entity-body>
```
* **Status**: A **three-digit number** describing what happened. The **first digit** describes the general class.
* **Reason-phrase**: A **human-readable** version of the status code.

**Example**: `HTTP/1.0 200 OK`
### 3.3 Status Code Classes

| Range | Category | Meaning |
|---|---|---|
| **1xx** (100–199) | **Informational** | Request received, continuing process |
| **2xx** (200–299) | **Successful** | Request successfully received and processed |
| **3xx** (300–399) | **Redirection** | Further action needed to complete request |
| **4xx** (400–499) | **Client error** | Request contains bad syntax or cannot be fulfilled |
| **5xx** (500–599) | **Server error** | Server failed to fulfil a valid request |

**Key status codes to remember**: **200** OK (success), **401** Unauthorized (need credentials), **403** Forbidden, **404** Not Found, **408** Request Timeout, **429** Too Many Requests, **500** Internal Server Error.

**Exam note (2020 Q2s)**: Status codes 401, 403, 404, 408, and 429 are all indicators that a **web crawler is being blocked**.

### 3.4 HTTP Message Line Endings
**Exam trap (2020 Q1.3)**: "Each line in an HTTP message ends with a two-character end-of-line sequence, consisting of a carriage return and a **tab** character" — **False**. The end-of-line sequence is a **carriage return** followed by a **line feed** (CRLF: `\r\n`), **not** a tab character.
## 4. HTTP Headers
Each HTTP header has a simple syntax: a **name**, followed by a **colon** (`:`), followed by the **field value**.
### 4.1 Header Types
* **General headers**: Used by both clients and servers (e.g. `Date: Tue, 3 Oct 1974 02:16:00 GMT`)
* **Request headers**: Provide extra information to servers (e.g. `Accept: */*` — the client accepts any media type)
* **Response headers**: Provide information to the client (e.g. `Server: Tiki-Hut/1.0`)
* **Entity headers**: Deal with the entity body (e.g. `Content-Type: text/html; charset=iso-latin-1`)
### 4.2 Common Header Examples

| Header | Description |
|---|---|
| `Date: Tue, 3 Oct 1997 02:16:03 GMT` | Date the server generated the response |
| `Content-length: 15040` | Entity body contains 15,040 bytes of data |
| `Content-type: image/gif` | Entity body is a GIF image |
| `Accept: image/gif, image/jpeg, text/html` | Client accepts GIF, JPEG images and HTML |

## 5. MIME Types
> **MIME (Multipurpose Internet Mail Extensions)** types were **originally designed for electronic mail**. HTTP adopted them to describe **multimedia content** in headers.

Each MIME type consists of a **primary type** and a **subtype** separated by a **slash** (`/`), with optional parameters beginning with a **semicolon** (`;`).

**Format**: `primary-type/subtype` (e.g. `text/html`, `image/jpeg`)
### 5.1 Primary Types

| Type | Description |
|---|---|
| **application** | Application-specific content (discrete type) |
| **audio** | Audio format |
| **image** | Image format |
| **text** | Text format |
| **video** | Video movie format |
| **multipart** | Collection of multiple objects (composite type) |
| **message** | Message format (composite type) |
### 5.2 MIME Type Examples (Exam-Critical)
* `text/html` — HTML document
* `text/plain` — Plain ASCII text
* `image/jpeg` — JPEG image
* `image/gif` — GIF image
* `video/quicktime` — Apple QuickTime movie
* `application/vnd.ms-powerpoint` — Microsoft PowerPoint

**Exam trap (2020 Q2f)**: "Which of the following is NOT a valid MIME type?" — `video/html` is **NOT valid**. There is no `html` subtype under the `video` primary type. Valid ones include `image/gif`, `application/vnd.ms-powerpoint`, and `text/plain`.
### 5.3 MIME Registration with IANA
MIME types are registered and maintained by **IANA (Internet Assigned Numbers Authority)**, **not** by IETF.

**Exam trap (2020 Q1.7)**: "MIME types are registered and maintained by the Internet Engineering Task Force (IETF)" — **False**. They are registered with **IANA**. (Note: the IETF *tree* is one of the four registration trees, but IANA is the registry authority.)

**Four registration trees**:
* **IETF** — general significance types (e.g. `text/html`); no periods in tokens
* **Vendor (vnd.)** — commercially available products (e.g. `image/vnd.fpx`); begin with `vnd.`
* **Personal/Vanity (prs.)** — private types; begin with `prs.`
* **Experimental (x- or x.)** — unregistered/experimental types; begin with `x.` or `x-`
## 6. HTTP Methods (Verbs)

| Method | Description | Message Body? |
|---|---|---|
| **GET** | Get a document from the server | **No** (recommended) |
| **HEAD** | Get just the **headers** (no entity body returned) | **No** |
| **POST** | Send input data to the server for processing | **Yes** |
| **PUT** | Store/write the body of the request on the server | **Yes** |
| **TRACE** | Trace the message through proxy servers to the server | **No** |
| **OPTIONS** | Determine what methods can operate on a server | **No** |
| **DELETE** | Remove a document from the server | **No** |
### 6.1 GET
The **most common** method. Used to ask a server to send a resource. GET *can* technically have a message body, but it is **recommended not to send data in it**. Instead, data should be sent in a **query string**.

**Exam trap (2019 Q1o)**: "A GET request is used when we do not intend to change the data on a server, and therefore a GET message should not have a payload" — **True**. GET is a **safe** method (does not modify server state) and should not carry a payload body.
### 6.2 HEAD
Behaves like GET, but the server returns **only the headers** — **no entity body is returned**.

**Uses of HEAD**: determine the **resource type** without downloading, check if an object **exists** (via status code), test if a resource has been **modified** (via `Last-Modified` header).

**Exam trap (2020 Q1.4)**: "Response messages to HTTP HEAD requests do not have a body" — **True**.
### 6.3 POST
Sends **input data to the server** for processing. Often used to support **HTML forms**. The data is carried in the **entity body** of the request.
### 6.4 PUT
Writes/stores documents or data on the server. The body of the request contains the data to be stored. The server updates or creates the resource at the specified URL.

**PUT vs POST**: **PUT** stores/replaces a resource at a **known URL** (idempotent). **POST** submits data for processing, and the server decides where/how to store it (not idempotent).
### 6.5 TRACE
Allows clients to see how its request looks when it finally reaches the server (useful for diagnosing proxy modifications). The server returns a TRACE response with the **original request message** in the body.
### 6.6 OPTIONS
Asks the server about **supported capabilities** — what methods it supports in general or for particular resources.
### 6.7 DELETE
Asks the server to delete the resource. There is **no guarantee** the delete is carried out — the HTTP specification allows the server to **override the request** without telling the client.
### 6.8 Extension Methods
HTTP is **field-extensible**. Extensions like **WebDAV** add methods such as `LOCK`, `MKCOL`, `COPY`, and `MOVE`. These are **not standard HTTP methods**.
## 7. Past Paper Traps for Lecture 2

| Statement                                                                            | Answer    | Reason                                                                      |
| ------------------------------------------------------------------------------------ | --------- | --------------------------------------------------------------------------- |
| "Each line ends with carriage return and **tab** character"                          | **False** | It ends with carriage return and **line feed** (CRLF)                       |
| "Response messages to HTTP HEAD requests do not have a body"                         | **True**  | HEAD returns headers only, no entity body                                   |
| "Anything that has a URL is a resource"                                              | **True**  | Definition from the lecture                                                 |
| "The server's representation always matches its internal representation" (2020 Q1.6) | **False** | The server sends a **representation** that may differ from internal storage |
| "MIME types are registered and maintained by IETF"                                   | **False** | Registered with **IANA**                                                    |
| `video/html` is a valid MIME type                                                    | **False** | `video` primary type has no `html` subtype                                  |
| "MOVE" is a standard HTTP method                                                     | **False** | MOVE is a **WebDAV extension**, not standard HTTP                           |
| "A URL is not the same as a URI"                                                     | **True**  | A URL is a subset/type of URI                                               |
| GET request should not have a payload                                                | **True**  | GET is safe; data goes in the query string                                  |
| Which method to book a flight? (2020 Q2i)                                            | **POST**  | Creating a new booking = POST (not GET, PUT, or ADD)                        |
# Lecture 3: Representational State Transfer (REST)
## 1. Origin of REST
> **REST (Representational State Transfer)** was coined by **Roy Fielding**, circa **2000**, in his PhD thesis about network-based software architectures.
## 2. Dissecting the Term REST
### 2.1 Representational
**Representational** refers to how data is **represented** when it is sent over the web. The representation of data does **not necessarily match** the way it is stored on the server (or client).

**Example**: Data stored on a server as a **CSV file** could be represented in **JSON**, **HTML**, **XML**, or even **plain text** formats when sent to the client.

**Exam trap (2020 Q1.6)**: "When a client requests a resource, the server responds with a representation of this resource that **always matches** the server's internal representation of the resource data" — **False**. The representation sent to the client can differ from how the resource is internally stored.
### 2.2 State
**State** describes the state of an entity — what the entity knows about the world. As a client interacts with a server, it gradually learns about and discovers new resources, and its **state changes**.

**Example**: When a web browser first loads, it knows nothing about a website except its root URL. As the user follows hyperlinks, the client acquires more information and its state changes.
### 2.3 Transfer
**Transfer** denotes the transfer of a **representation** from server to client (or vice versa).
### 2.4 Putting It Together
> **Representational State Transfer** means: the change in the **state** of an entity (either client or server) driven by a **representation transferred** to it from another entity.

This is exactly what happens when browsing a website — as we follow hyperlinks from page to page, we discover new information and our state (of knowledge) changes.
## 3. Usage of the Term REST
The term REST is widely used and often **abused**. People tend to use it to describe any API that doesn't use SOAP. However, for an API to be truly **RESTful**, it must satisfy a number of **design (architectural) constraints** set out by Roy Fielding. Many APIs that call themselves RESTful only **partially fulfil** these constraints.
### 3.1 Web Service vs API
The term "web service" became so tightly coupled with SOAP that today it is more common to use the term **RESTful API** instead of RESTful web service (though both are correct).
## 4. The Five REST Constraints

### 4.1 Client-Server Architecture
The most obvious constraint — satisfied by every web application. The client and server are separated.

**Advantages**: improves **portability** of the user interface across multiple platforms (e.g. many different browsers interacting with the same website), and allows components to **evolve independently**.
### 4.2 Statelessness
> **Statelessness** means that each request from client to server must contain **all the information necessary** to understand the request, and does **not rely on any previous requests**. No client context is stored on the server between requests.

**Stateful (Case A)**: Student says "My name is Mike, student id 123, email m@g.com. Can I know my grade?" Then later says "Can you email me the slides?" — the second request relies on the server **remembering** who the student is. This is **stateful**.

**Stateless (Case B)**: Student repeats their full identity in **every** request. "My name is Mike, student id 123, email m@g.com. Can you email me the slides?" — this is **stateless** because each request is **self-contained**.

**Exam trap (2020 Q2h)**: "In RESTful APIs, statelessness means that: 
- A. No client context is stored on the server between requests. 
- B. Each request contains all the information necessary to service the request. 
- C. The session state is held in the client. 
- D. **All of the above.**" 

— Answer is **D. All of the above**.

**Advantages of Statelessness**:

- Improved **reliability** — ability to recover from partial failure; if communication breaks, the process can continue later
- Improved **visibility** — a monitoring system only needs to look at a single request to understand it
- **Simplifies implementation** — the server doesn't have to remember previous requests

**Disadvantages of Statelessness**:

- Can decrease **network performance** by increasing repetitive data sent in a series of requests
- Placing application state on the client-side reduces the **server's control** over application behaviour
### 4.3 Cacheability
> Data within a response must be **implicitly or explicitly labelled** as **cacheable or non-cacheable**. If cacheable, the client cache can **reuse** that response data for later equivalent requests.

**Advantage**: Eliminates some interactions, improving **performance** and reducing **latency**. **Disadvantage**: Reduced **reliability** if **stale data** in the cache differs from data on the server.
### 4.4 Uniform Interface
The most important constraint, divided into **4 sub-constraints**:
#### **4.4.1 Identification of Resources** — 
Each resource must be identified by a **unique and stable identifier**:
- **Unique**: each identifier points to one and only one resource
- **Stable**: should not be altered later on
- **Persistent**: remains valid as long as the resource exists
- **Opaque**: clients don't need to understand what the ID means

**Good REST identifiers**: 
- `/users/123`, 
- `/blog/2025/02/03/rest-tutorial`, 
- `/invoices/INV-2024-0003` 
**Bad REST identifiers**: 
- `/getUser/getUserData/fetchOrder` (verbs in URL), 
- `/user?id=123` (query string as identifier), 
- `/users/current` (unstable — changes depending on who's logged in)
#### **4.4.2 Manipulation of Resources Through Representations** — 
The client does **not directly manipulate** the resource itself. Instead, it works with a **representation** of that resource, and the server uses that representation to update the real thing. The representation contains **all the information** needed to process the request.
#### **4.4.3 Self-Descriptive Messages** — 
Messages should carry **all the information** that the receiving party needs to process the message successfully. 

For example, the **media type** of the message body should be stated (e.g. `Content-Type: application/json`) so the receiver knows how to interpret the payload.
#### **4.4.4 HATEOAS (Hypermedia As The Engine Of Application State)** — 
A representation returned from the server should contain **hypermedia references (hyperlinks)** to perform further actions or access related resources. This is sometimes called the **discoverability rule**.

**Example**: If an e-commerce client requests a shopping cart's contents, the server should also send hyperlinks for **checkout**, **payment**, and other related actions — not just the cart data.

**Exam trap (2020 Q2d)**: "Which of the following is NOT an essential part of a RESTful API working cycle? 
- A. Client requests a representation of a resource. 
- B. **Client captures the structure of the resource in a DOM tree.** 
- C. Client decides on a new resource to be requested. 
- D. Client changes its current state when the new resource is received." 

— Answer is **B**. Capturing structure in a DOM tree is not a REST constraint; it's a browser implementation detail.
### 4.5 Layered System
> A **layered architecture** allows the API implementation to reside on one server but source data from a **separate database server**, or perform authentication from yet another server.

From the client's perspective, it connects **directly with the end server** and has **no knowledge of the intermediaries** along the way. Each layer is only aware of the **next layer**, not layers beyond it.

**Advantage**: Boosts **scalability** as tasks (security, storage, authentication) are separated between servers without burdening the client. 
**Disadvantage**: Adds **latency** because each request needs to go through several layers.
## 5. The Semantic Gap (Exam-Critical)
**Exam trap (2020 Q2g)**: "The biggest challenge in RESTful web API design is: 
- A. Finding suitable media types to represent all the resources. 
- B. **Bridging the semantic gap between understanding a document's structure and understanding what it means.** 
- C. Avoiding identical URLs. 
- D. Parsing representations." 

— Answer is **B**. The semantic gap is about the difference between understanding a document's structure (e.g. HTML tags) and understanding what the data actually _means_.
## 6. Fiat Standards
**Exam trap (2020 Q2e)**: "In RESTful APIs, a 'fiat standard' is called as such because: 
- A. **No one agreed to it. It is just a description of the way somebody does things.** 
- B. It is widely accepted like FIAT cars. 
- C. Set by FIAT team. 
- D. Set by the US government."
— Answer is **A**. A fiat standard is one that is simply a description of how someone does things, without formal agreement or standardisation body approval.
## 7. Past Paper Traps for Lecture 3

| Statement                                                                                                          | Answer                                               | Reason                                                |
| ------------------------------------------------------------------------------------------------------------------ | ---------------------------------------------------- | ----------------------------------------------------- |
| "REST stands for Representational State **Transitions**"                                                           | **False**                                            | It is Representational State **Transfer**             |
| Statelessness means "all of the above" (no context stored, each request is complete, session state held in client) | **True**                                             | All three statements describe statelessness           |
| The server's representation always matches its internal representation                                             | **False**                                            | Representation can differ from internal storage       |
| Client capturing DOM tree is essential to REST                                                                     | **False**                                            | DOM trees are a browser detail, not a REST constraint |
| The biggest challenge in REST API design is the **semantic gap**                                                   | **True**                                             | Understanding meaning vs structure                    |
| A "fiat standard" means no one formally agreed to it                                                               | **True**                                             | It's just how someone does things                     |
| What data type should the server use to return a list? (2020 Q2j)                                                  | **D. Any of the above** (JSON, XML, Collection+JSON) | REST supports multiple representation formats         |
# Lecture 4: Bridging the Semantic Gap

## 1. The REST Cycle (Recap)
When a human browses the web, the cycle is:
1. Request a web page
2. Server sends the page (e.g. HTML)
3. **Read** the page
4. **Change current state** (understanding) using information
5. Recognise links to other pages
6. **Decide** which new page to request → back to step 1

> **REST** works the same way, except a **software agent (client)** takes the role of the human:
> 1. Client **requests** a representation of a resource
> 2. Server sends representation (e.g. HTML, JSON, XML)
> 3. Client **parses** the representation
> 4. Client **changes its current state** using information in the representation
> 5. Client **recognises control structures** (e.g. `<a>` tags, hypermedia links)
> 6. Client **decides** on a new resource to request → back to step 1
## 2. The Core Challenge
Steps 1–5 can be easily implemented in **fully autonomous code**. But **Step 6 (deciding which new resource to request) is difficult**. Why?

> A computer program can easily understand a document's **structure** (e.g. discover HTML links), but it cannot understand **what each link actually does**.

**Example**: An HTML page contains a link `<a href="/pay">Click here to pay</a>`. A computer sees a hyperlink to `/pay`, but it doesn't know that following this link will **transfer money**. The human knows; the machine does not.

> **Semantic gap**: the difference between understanding the **syntax/structure** of a document and understanding its **meaning** in the application domain.

**Exam trap (2020 Q2g)**: "The biggest challenge in RESTful web API design is bridging the **semantic gap**." – **True**.
## 3. Can We Bridge the Semantic Gap?
> **No magic shortcut**. We cannot eliminate the semantic gap completely because computers are not as smart as humans. However, we can **narrow the gap** with good API design.
### 3.1 Role of the API Designer
To bridge the semantic gap (from server to client), the API designer should:
1. **Write down application semantics** in a **human-readable specification**
2. **Register one or more IANA media types** for the design. In the registration, associate the media types with the human-readable specification.
### 3.2 Role of the Client Developer
To bridge the gap in the opposite direction (client understanding server responses), the client developer:
1. Looks up an **unknown media type** in the **IANA registry**
2. **Reads the human-readable specification** to learn how to deal with documents of that media type
## 4. Example: Maze+XML API
To illustrate bridging the semantic gap, consider a **maze navigation API**. Any complex problem can be represented as a maze:
- Problem is too complex to understand all at once
- Every client begins at the same **first step**
- At each step, the server presents **possible next steps**
- Client decides which next step to take
- Client knows what counts as **success** and when to stop
### 4.1 Maze+XML Media Type
> **Media type name**: `application/vnd.amundsen.maze+xml`

The `+xml` suffix indicates the **underlying syntax** is XML, but the **semantics** are defined specifically for mazes.

> **Structured syntax suffix** (e.g. `+xml`, `+json`, `+zip`) is an augmentation to a media type that specifies the underlying structure (syntax). Registered and maintained by **IANA**.

**Registered suffixes include**: `+xml`, `+json`, `+zip`, `+ber`, `+der`, `+fastinfoset`, `+wbxml`, `+cbor`.
### 4.2 Fiat Standards

> **Fiat standards** are not really standards; they are **behaviours**. No one agreed to them. They are just a description of the way somebody does things.

The behaviour may be documented, but they lack the core assumption of a standard—that other people **ought to do things the same way**.

**Examples**: "Twitter API", "Facebook API", "Google API" – each is a **one-off design** associated with a specific company.

> **Note**: It is **not recommended** to create new domain-specific media types. It is less work to add application semantics to a **generic hypermedia format** (e.g. using standard link relations). But a domain-specific design is the first instinct of many developers.

**Exam trap (2020 Q2e)**: "A 'fiat standard' means no one formally agreed to it; it's just a description of how someone does things." – **True**.

### 4.3 How Maze+XML Works
Each **cell** in the maze is a resource with its own **URL**.

**Representation of a cell** (GET request to `/cells/M`):
```xml
<maze version="1.0">
  <cell href="/cells/M" rel="current">
    <title>The Entrance Hallway</title>
    <link rel="east" href="/cells/N"/>
    <link rel="west" href="/cells/L"/>
  </cell>
</maze>
```

- `<link>` tags connect the current cell to neighbours
- **Link relation** (`rel="east"`, `rel="west"`) explains **what will happen** if the client follows that link

> **Link relation** = a string associated with a hypermedia control. It explains the **change in application state** (for safe requests) or **resource state** (for unsafe requests) that will occur if the client triggers the control.
### 4.4 Link Relations – Registered vs Extension
- **Registered relation types**: Short strings like `next`, `previous`, `search`, `alternate`. Managed by **IANA**. Currently ~60 registered relations.
- **Extension relation types**: Look like **URLs**. If you own a domain, you can name a link relation `http://mydomain.com/whatever` and define it to mean anything you want.

**Common registered HTML link relations** (exam-relevant):

| Value | Description |
|-------|-------------|
| `alternate` | Alternate representation (e.g. print page, translated) |
| `author` | Link to author of the document |
| `bookmark` | Permanent URL for bookmarking |
| `external` | Referenced document is not part of the same site |
| `help` | Link to a help document |
| `license` | Copyright information |
| `next` | Next document in a series |
| `prev` | Previous document in a series |
| `nofollow` | Links to an unendorsed document (used by Google – crawler should not follow) |
| `search` | Link to a search tool for the document |
| `tag` | A tag/keyword for the current document |

**Example**: `<a rel="nofollow" href="http://www.functravel.com/">Cheap Flights</a>`
### 4.5 Changing Application State by Following Links
When a client **follows** a link (e.g. `rel="east"` to `/cells/N`), it receives a **new representation** of the destination cell:

```xml
<maze version="1.0">
  <cell href="/cells/N">
    <title>Foyer of Horrors</title>
    <link rel="north" href="/cells/I"/>
    <link rel="west" href="/cells/M"/>
    <link rel="east" href="/cells/O"/>
  </cell>
</maze>
```

- The client's **application state** has changed – it was "visiting" cell M, now it is "visiting" cell N
- New options appear (north, west, east)

When the client reaches the **exit**, the representation includes a special link:
```xml
<link rel="exit" href="/success.txt"/>
```

### 4.6 How Does the Client Know Where to Start?
There is no `rel="entrance"` defined. The Maze+XML standard solves this with a **collection**:

**Root URL response** (collection of mazes):
```xml
<maze version="1.0">
  <collection>
    <link rel="maze" title="A Beginner's Maze" href="/beginner"/>
    <link rel="maze" title="For Experts Only" href="/expert-maze/start"/>
  </collection>
</maze>
```

**GET `/beginner`** returns:
```xml
<maze version="1.0">
  <item>
    <title>A Beginner's Maze</title>
    <link rel="start" href="/cells/C"/>
  </item>
</maze>
```

- `rel="maze"` → takes client to an individual maze
- `rel="start"` → takes client to the start cell of the maze
### 4.7 Client Knowledge (Programmed from Specification)
A client that has been programmed with the Maze+XML specification knows:
- How to parse the **collection** representation
- That `rel="maze"` indicates an individual maze → perform a GET
- How to parse an **individual maze** representation
- That `rel="start"` indicates the entrance → perform a GET
- How to parse a **cell** representation
- What `east`, `west`, `north`, `south` mean → translate movement into HTTP GETs
- What `exit` means → knows when the maze is completed

> **Key insight**: Starting with **no information except the root URL**, a correctly programmed client can discover **everything** – all mazes, all cells, all navigation options – by following hypermedia links. This is **HATEOAS** in action.
### 4.8 Human-Driven vs Automated Clients
**Human-driven client** (e.g. mobile app for a human to play the maze game):
- Human makes the decisions about where to go
- **Semantic gap is not a problem** because the human understands the meaning

**Automated client** (e.g. "Mapmaker" – a client that maps the entire maze by automatic exploration):
- Must be **pre-programmed** with the semantics (what `east`, `west`, `exit`, `start`, `maze` mean)
- The specification **bridges the gap** for the automated client
## 5. Summary: Bridging the Semantic Gap

- There is **no magic shortcut**; computers are not as smart as humans
- We can **narrow** the gap by:
  1. Defining **application-specific link relations** (or reusing registered ones)
  2. Registering **IANA media types** with human-readable specifications
  3. **Client developers reading and implementing** those specifications
- **HATEOAS** (hypermedia links) enables **discoverability** – clients can navigate from a root URL to all resources without out-of-band knowledge of URLs

**Exam trap (2020 Q2c)**: "In HTML, a link relation (rel) can be added to: A. `<link>` elements only. B. `<a>` elements only. C. **Both `<a>` and `<link>` elements**. D. None of the above." – Answer is **C**.

**Exam trap (2020 Q2k)**: "Which one is NOT a feature of a badly designed robot? A. Quick requests to same site. B. Failure to read robots.txt. C. **Failure to set a value to the Accept HTTP header field**. D. Making requests at a regular monotonous rate." – Answer is **C** (not setting Accept is poor practice but not a sign of a bad robot; the others are bad behaviours). Wait, re-read: The question asks "NOT a feature of a badly designed robot". Failure to set Accept header is not necessarily bad – many simple robots don't. Quick requests, ignoring robots.txt, monotonous rate – all are bad. So answer is C.

**Exam trap (2020 Q2j)**: "Which data type should the server use to return a list of items? A. JSON B. XML C. Collection+JSON D. **Any of the above**" – Answer is **D**. REST does not mandate a specific format.
# Lecture 5: The Hypermedia Zoo

## 1. Media Types Overview

> A **media type** (formerly MIME type) describes the format of data sent over HTTP. Hundreds of (hyper)media types are available for web services. Choosing the right one depends on the application: human vs machine consumption, data complexity, bandwidth constraints.

**Key decision factors**:
- **Human-readable** vs **machine-readable**
- **Structure** required (simple text vs complex nested data)
- **Bandwidth** overhead (heavy vs lightweight)
- **Semantic gap** (does the format itself convey meaning, or must semantics be defined separately?)

## 2. Plain Text (`text/plain`)

> **Plain text** has no structure beyond natural language rules (vocabulary, grammar). Best for **very short API responses targeted at humans**.

**Example**: A simple status endpoint returning `"OK"` or `"Service unavailable"`.

**Limitations**: No machine-readable structure, no hypermedia controls, no data typing.

## 3. HTML – HyperText Markup Language (`text/html`)

> **HTML** is the oldest and most widely used hypermedia format (dating to 1993). It is **textual**, readable by humans and machines. Tags denote document structure (headings, paragraphs, lists). Browsers render based on tags, but **tags themselves are not displayed**.

### 3.1 HTML Evolution
- Early versions: only structural tags for textual content.
- Later versions added: images, video, audio, **JavaScript** (client-side scripting), **forms** (deliver content to server), **CSS** (rendering control – without CSS, the client decides how to render).
- **HTML5.2** was the last numbered version. HTML is now a **living standard** (continuously updated without version numbers).

### 3.2 Advantages of HTML
- Widely used → extensive support, tools, libraries on all platforms.
- Ideal for applications serving **human-readable data** (web pages).
- Rich features (multimedia, interactivity, forms).
- Can **embed other data formats** (e.g. XML, JSON inside `<script>` or as data attributes).

### 3.3 Disadvantages of HTML
- Designed for **human-readable documents**, not pure data for machine-to-machine communication (e.g. database records, spreadsheet values).
- **Verbose**: useful content surrounded by large amounts of metadata (tags, attributes) → increases bandwidth.

**Exam insight**: HTML is for **machine-to-human** communication; XML/JSON are for **machine-to-machine**.

## 4. XML – Extensible Markup Language (`application/xml` or `text/xml`)

> **XML** (first published 1998) is a textual markup language similar in syntax to HTML, but with a key difference: **HTML tags are predefined with specific semantics**; **XML tags can be anything**. XML's purpose is **pure data representation and serialisation**, independent of rendering.

### 4.1 Key Characteristics
- The XML standard imposes **syntax rules only** (well-formedness: closing tags, proper nesting, quotes around attributes). It assigns **no semantics** to tags.
- Anyone can invent their own XML-based format and define the semantics separately (e.g. in a human-readable specification or schema).
- **Natural choice for SOAP** – SOAP uses XML for data exchange.

### 4.2 Advantages of XML
- **Underlying syntax for any media type** (e.g. Maze+XML uses `+xml` suffix).
- **Human-readable and machine-readable** (text-based).
- Excellent for **tree-like data structures**.
- **Platform independent** (shared by all text-based formats).
- You can **invent your own XML-based format** to match your application's semantics.

### 4.3 Disadvantages of XML
- **Heavyweight**: contains much metadata (tag delimiters, opening/closing tags). Each tag requires ~7 lexical tokens.
- **No built-in semantics** – must be defined separately (creates extra work and risks semantic gap).

## 5. XML-Based Formats (Piggybacking on XML)

Hundreds of data formats use XML as the underlying representation. Key examples:

| Format | Media Type | Purpose |
|--------|------------|---------|
| **RSS** (Really Simple Syndication) | `application/rss+xml` | Client access to website updates (feeds) |
| **Atom** (Atom Syndication Format) | `application/atom+xml` | Alternative to RSS; more robust |
| **SOAP** | `application/soap+xml` | SOAP-based web services |
| **Maze+XML** | `application/vnd.amundsen.maze+xml` | Maze navigation (lecture 4 example) |
| **Custom** | Your own (e.g. `application/vnd.mycompany.myformat+xml`) | Only as last resort to avoid fiat standards |

### 5.1 RSS Example (simplified)
```xml
<rss>
  <channel>
    <title>RSS Title</title>
    <item>
      <title>Example entry</title>
      <description>Interesting description</description>
      <link>http://example.com/post/1</link>
    </item>
  </channel>
</rss>
```

### 5.2 Atom Example (simplified)
```xml
<feed xmlns="http://www.w3.org/2005/Atom">
  <title>Example Feed</title>
  <entry>
    <title>Atom-Powered Robots Run Amok</title>
    <link href="http://example.org/2003/12/13/atom03"/>
    <summary>Some text.</summary>
  </entry>
</feed>
```

**Difference**: Atom has stricter standards, better support for metadata (author, updated time), and is IETF standard. RSS is simpler but has multiple incompatible versions.

### 5.3 Creating Your Own XML Media Type
- If no existing XML format meets your needs, you **can create your own** and attempt to register with IANA.
- **Use as last resort** to avoid creating yet another **fiat standard**.

## 6. JSON – JavaScript Object Notation (`application/json`)

> **JSON** (devised circa 2001) is a human-readable, language-independent data format. Despite the name, it is **not tied to JavaScript**. It is built on two universal data structures:

1.  **A collection of name-value pairs** (object, record, dict, hash table, associative array)
2.  **An ordered list of values** (array, vector, list, sequence)

These structures are supported by **all programming languages**, making JSON highly interoperable.

### 6.1 JSON Example
```json
{
  "person": {
    "name": "Alice Johnson",
    "age": 29,
    "hobbies": ["hiking", "photography", "cooking"],
    "employed": true
  }
}
```

### 6.2 Advantages of JSON
- **Low overhead** alternative to XML → reduces storage and bandwidth.
- **Easy to parse** (native in JavaScript, libraries in all languages).
- Can represent **almost all kinds of data** (nested objects, arrays, primitives).
- **Human-readable** (similar to JavaScript object literal syntax).

### 6.3 Disadvantages of JSON
- **No comments** (cannot annotate data; workaround: use `"_comment"` field, but that's non-standard).
- Shares limitations of other text-based formats (no built-in security, no schema by default – though JSON Schema exists separately).

**Exam note**: SOAP uses XML **only**; REST APIs commonly use JSON, but can use XML or others.

## 7. YAML – YAML Ain't Markup Language

> **YAML** is a human-friendly data serialisation standard. **Indentation defines structure** (spaces only – tabs not allowed). Often used for **configuration files** (e.g. Docker Compose, CI/CD pipelines).

### 7.1 YAML Syntax Features
- **Key-value pairs**: `key: value`
- **Lists**: `- item` (dash and space)
- **Nested structures**: via indentation
- **Comments**: start with `#` (JSON lacks this)
- **Scalars**: strings (can be unquoted, single, or double quoted), numbers, booleans, `null`

### 7.2 YAML Example
```yaml
# Basic user profile
user:
  name: "Alice Johnson"  # string
  age: 29                # number
  hobbies:               # list
    - hiking
    - photography
    - cooking
  enabled: true
```

**Comparison**: YAML is **more human-readable** than JSON (fewer brackets, comments), but **whitespace-sensitive** (can cause errors). JSON is more common for web APIs due to simpler parsing and widespread library support.

## 8. Choosing a Media Type – Summary

| Format | Media Type | Best For | Human-Readable | Machine-Readable | Comments | Overhead |
|--------|------------|----------|:--------------:|:----------------:|:--------:|:--------:|
| Plain text | `text/plain` | Short human messages | ✓ | ✗ | ✗ | Very low |
| HTML | `text/html` | Web pages (human consumption) | ✓ | Partial | ✓ | High (metadata) |
| XML | `application/xml` | Machine-to-machine, complex trees | ✓ | ✓ | ✓ | High |
| JSON | `application/json` | Machine-to-machine, lightweight APIs | ✓ | ✓ | ✗ | Low |
| YAML | `application/yaml` | Configuration files | ✓ | ✓ | ✓ | Low |

**Exam trap (general)**: "SOAP uses JSON" – **False** (SOAP uses XML only).  
**Exam trap**: "HTML is the best choice for representing pure database records" – **False** (HTML is for human documents; JSON/XML are better).  
**Exam trap**: "JSON supports comments" – **False** (JSON does not support comments; YAML does).

## 9. Past Paper Relevance for Lecture 5

| Statement / Question | Answer | Reason |
|----------------------|--------|--------|
| SOAP uses which data format? | **XML** | SOAP is XML-based |
| Which is NOT a valid MIME type? `video/html` | Invalid | No `html` subtype under `video` |
| JSON advantages include? | Low overhead, easy to parse | Compared to XML |
| JSON disadvantages include? | No comments | Not self-documenting |
| What is a living standard? | Continuously updated without version numbers | Current HTML status |
# Lecture 6: Django – Introduction & Setup

## 1. What is Django?

> **Django** is a free, open-source **web framework** written in **Python**. It follows the **MVT (Model-View-Template)** pattern and includes an **ORM** (Object-Relational Mapping) layer, an **admin site** automatically generated, and a **URL dispatcher**.

**Key fact for exam**: Django is used in the **practical coursework** and appears in **scenario questions** (e.g. 2019 Q5) where you may need to write **pseudocode for view functions** (handlers) or describe model relationships.

## 2. Django Project vs Application

> A **project** is the entire website/application. A project can contain **multiple applications** (apps). An app is a module that provides specific functionality (e.g. `books`, `ratings`, `users`).

**Commands**:
- Create project: `django-admin startproject <project_name>`
- Create app: `python manage.py startapp <app_name>`

**Registration**: After creating an app, you **must register it** in the project’s `settings.py` under `INSTALLED_APPS`. Use the app’s configuration class (e.g. `'books.apps.BooksConfig'`).

## 3. Django Models

> A **model** is a Python class that represents a **database table**. Models are defined in `models.py`. Each attribute is a **field** (column). Django automatically creates a primary key called `id` (accessed as `pk`).

**Example from lecture** (books application):
```python
from django.db import models

class Publisher(models.Model):
    name = models.CharField(max_length=30)
    address = models.CharField(max_length=50)
    city = models.CharField(max_length=60)
    website = models.URLField()

class Author(models.Model):
    first_name = models.CharField(max_length=30)
    last_name = models.CharField(max_length=40)
    email = models.EmailField()

class Book(models.Model):
    title = models.CharField(max_length=100)
    authors = models.ManyToManyField(Author)   # many-to-many
    publisher = models.ForeignKey(Publisher)   # many-to-one
    publication_date = models.DateField()
```

### 3.1 Field Types (exam-relevant)
- `CharField(max_length=…)` – short to medium strings
- `TextField` – long text
- `IntegerField`, `FloatField`
- `DateField`, `DateTimeField`
- `EmailField`, `URLField`
- `BooleanField`
- `ForeignKey` – many-to-one relationship
- `ManyToManyField` – many-to-many relationship
- `OneToOneField` – one-to-one

### 3.2 Relationships
| Relationship | Django Field | Example | Reverse accessor |
|--------------|--------------|---------|------------------|
| Many-to-one | `ForeignKey(OtherModel)` | Book → Publisher | `publisher.book_set.all()` |
| Many-to-many | `ManyToManyField(OtherModel)` | Book ↔ Author | `author.book_set.all()` |
| One-to-one | `OneToOneField(OtherModel)` | User → Profile | `user.profile` |

> **Reverse accessor naming**: `<model_name>_set` (lowercase model name followed by `_set`). For `ForeignKey` from `Book` to `Publisher`, `publisher.book_set` returns all books of that publisher.

## 4. Database Migration Commands

After defining models, create the database tables:

1. **Check** model validity: `python manage.py check`
2. **Create migration files**: `python manage.py makemigrations <app_name>`
3. **Apply migrations**: `python manage.py migrate`

> **Migration files** describe changes to the database schema. They are version-controlled.

## 5. Django Admin Site

Django can automatically generate an **admin interface** for managing data.

**Setup**:
1. Create a **superuser**: `python manage.py createsuperuser` (enter username, email, password)
2. Register models in `admin.py`:
   ```python
   from django.contrib import admin
   from .models import Publisher, Author, Book

   admin.site.register(Publisher)
   admin.site.register(Author)
   admin.site.register(Book)
   ```
3. Run development server: `python manage.py runserver`
4. Access admin at `http://127.0.0.1:8000/admin/`

## 6. View Functions (Request Handlers)

> A **view function** (defined in `views.py`) receives an `HttpRequest` object and returns an `HttpResponse`. Each view is associated with a **URL** via `urls.py`.

**Basic skeleton**:
```python
from django.http import HttpResponse

def my_view(request):
    # request.method tells you the HTTP verb
    if request.method == 'GET':
        # process GET
        return HttpResponse("GET response")
    elif request.method == 'POST':
        # process POST
        return HttpResponse("POST response")
```

### 6.1 Key `HttpRequest` Attributes (exam-relevant)
| Attribute | Description |
|-----------|-------------|
| `request.method` | HTTP method (e.g. `'GET'`, `'POST'`, `'PUT'`, `'DELETE'`) – always uppercase |
| `request.GET` | Query string parameters (dictionary-like) |
| `request.POST` | Form data (for POST requests) |
| `request.body` | Raw HTTP request body as byte string (for JSON, etc.) |
| `request.META` | Dictionary of HTTP headers (e.g. `request.META['CONTENT_TYPE']`) |
| `request.COOKIES` | Cookie dictionary |

### 6.2 URL Routing (urls.py)

**Mapping URLs to views**:
```python
from django.urls import path
from . import views

urlpatterns = [
    path('books/', views.book_list),           # fixed path
    path('books/<int:book_id>/', views.book_detail),  # variable path
]
```
- `path()` for simple routes; `re_path()` for regular expressions.
- Angle brackets capture variables (e.g. `<int:book_id>`) and pass them as arguments to the view function.

## 7. Testing Views (Development)

Use `runserver` and then send HTTP requests using:
- **curl** (command line)
- **HTTPie** (user-friendly)
- **Requests library** in Python
- Browser (for GET requests)

**Example** `curl` to test: `curl http://127.0.0.1:8000/books/`

---

# Lecture 7: More Django – Accessing and Filtering Data

## 1. Model Manager and QuerySets

> Every model has a default **manager** called `objects`. The manager provides methods to retrieve data, returning a **QuerySet** (a list-like collection of model instances).

**Common retrieval methods**:

| Method | Returns | Example |
|--------|---------|---------|
| `all()` | All records (QuerySet) | `Publisher.objects.all()` |
| `filter(**kwargs)` | Matching records (QuerySet) | `Publisher.objects.filter(country="USA")` |
| `get(**kwargs)` | **Single** model instance (raises exception if not found or multiple) | `Publisher.objects.get(id=1)` |
| `create(**kwargs)` | Create and save in one step | `Publisher.objects.create(name="Apress", ...)` |

## 2. Creating and Saving Objects

**Two-step save** (create then save):
```python
p = Publisher(name="Apress", address="...")
p.save()   # saves to database
```

**One-step creation**:
```python
p = Publisher.objects.create(name="O'Reilly", address="...")
```

## 3. String Representation (`__str__`)

> Always define a `__str__()` method on your models to make debugging and admin interface readable.

```python
class Author(models.Model):
    first_name = models.CharField(max_length=30)
    last_name = models.CharField(max_length=40)

    def __str__(self):
        return f"{self.first_name} {self.last_name}"
```

Without `__str__`, the QuerySet shows `<Publisher: Publisher object>`; with it, you see `<Publisher: Apress>`.

## 4. Filtering Data

**Exact match**:
```python
Publisher.objects.filter(name="Apress")
```

**Multiple conditions** (AND):
```python
Publisher.objects.filter(country="USA", state_province="CA")
```

**Field lookups** (double underscore syntax):
| Lookup | Meaning | Example |
|--------|---------|---------|
| `contains` | Case-sensitive containment | `name__contains="press"` |
| `icontains` | Case-insensitive | `name__icontains="press"` |
| `startswith` | Starts with | `name__startswith="A"` |
| `endswith` | Ends with | `name__endswith="ing"` |
| `exact` | Exact match (default) | `name__exact="Apress"` |
| `gt` / `lt` | Greater than / less than | `publication_date__gt="2020-01-01"` |
| `in` | In a list | `id__in=[1,3,5]` |

## 5. Retrieving Single Objects – `get()`

> `get()` returns **exactly one** object. If no object matches, raises `Model.DoesNotExist`. If multiple match, raises `MultipleObjectsReturned`.

```python
try:
    publisher = Publisher.objects.get(id=1)
except Publisher.DoesNotExist:
    # handle not found
```

**Exam note**: `get()` is for when you expect exactly one result. For zero or many, use `filter()` and then check existence or get first item.

## 6. Deleting Objects

**Delete a single object**:
```python
p = Publisher.objects.get(id=1)
p.delete()
```

**Bulk delete** (on a QuerySet):
```python
Publisher.objects.filter(country="USA").delete()
```

**Delete all**:
```python
Publisher.objects.all().delete()
```

## 7. Accessing Related Objects

### 7.1 ForeignKey (many-to-one)

**Forward access** (from child to parent):
```python
book = Book.objects.get(id=50)
publisher = book.publisher   # gets the related Publisher object
print(publisher.website)
```

**Reverse access** (from parent to child): use `childmodel_set` (lowercase model name + `_set`):
```python
p = Publisher.objects.get(name="Apress")
books = p.book_set.all()          # all Book objects with this publisher
books_by_title = p.book_set.filter(title__icontains="Django")
```

### 7.2 ManyToManyField

**Forward access** (from Book to Authors):
```python
book = Book.objects.get(id=50)
authors = book.authors.all()                     # all authors
adrian = book.authors.filter(first_name="Adrian") # filter
```

**Reverse access** (from Author to Books):
```python
author = Author.objects.get(first_name="Adrian")
books = author.book_set.all()
```

## 8. Model Methods (Custom Row-Level Logic)

> Add custom methods to a model to perform actions on **individual instances**. Define them in `models.py`.

```python
class Person(models.Model):
    first_name = models.CharField(max_length=50)
    last_name = models.CharField(max_length=50)
    birth_date = models.DateField()

    def baby_boomer_status(self):
        import datetime
        if self.birth_date < datetime.date(1945, 8, 1):
            return "Pre-boomer"
        elif self.birth_date < datetime.date(1965, 1, 1):
            return "Baby boomer"
        else:
            return "Post-boomer"

    @property
    def full_name(self):
        return f"{self.first_name} {self.last_name}"
```

- Use `@property` to make a method accessible as an attribute (`person.full_name`).
- Common use: override `save()` to perform actions before or after saving.

## 9. Overriding `save()` and `delete()`

```python
class Blog(models.Model):
    name = models.CharField(max_length=100)
    tagline = models.TextField()

    def save(self, *args, **kwargs):
        # do something before saving
        self.tagline = self.tagline.capitalize()   # example
        super().save(*args, **kwargs)   # call the real save
        # do something after saving
```

## 10. QuerySet Features

- **Iterable**: `for book in Book.objects.all(): print(book.title)`
- **Slicable**: `Book.objects.all()[5:10]` (returns QuerySet, not evaluated until needed)
- **Lazy evaluation**: QuerySets are not executed until you iterate, slice, or call `len()`, `list()`.
- **`values()` method**: returns dictionaries instead of model instances (lighter, faster for specific fields).
```python
# Returns list of dicts
publisher_data = Publisher.objects.filter(name__startswith="A").values()
# [{'id': 1, 'name': 'Apress', ...}, ...]
```

## 11. Exam Relevance for Django Lectures

| Concept | Past Paper Link | Tip |
|---------|----------------|-----|
| Models and relationships (ForeignKey, ManyToManyField) | 2019 Q5 (professors, modules, ratings) | Identify the correct relationships: ModuleInstance → Professor (many-to-many), Rating → User (ForeignKey), Rating → ModuleInstance (ForeignKey) |
| View function pseudocode | 2019 Q5 | Write `def handle_rating(request):` check `request.method`, parse JSON, use `objects.create()`, return JSON response |
| Admin site | 2019 Q5 "admin site automatically created by the web development framework" | Django automatically provides admin; manual data entry via admin interface |
| URL routing | Scenario design | Plan endpoints like `GET /module-instances`, `POST /ratings` |
| QuerySet filtering | Not directly in past papers but could appear | Know `filter()`, `get()`, `_set` reverse lookups |

**Example scenario (2019 Q5)** – You would create models:
- `Professor` (name, unique identifier)
- `Module` (code, name)
- `ModuleInstance` (module, year, semester, professors – ManyToManyField to Professor)
- `Rating` (user, module_instance, professor, score, date)
- `User` (username, email, password – can extend Django’s built-in User model)

**View for average rating**:
```python
def professor_rating(request, prof_id):
    if request.method == 'GET':
        ratings = Rating.objects.filter(professor_id=prof_id)
        avg = ratings.aggregate(Avg('score'))['score__avg']
        rounded = round(avg) if avg else 0
        return JsonResponse({'professor_id': prof_id, 'average_rating': rounded})
```
# Lecture 8: RESTful API Design Exercise (2019 Q5 Solution)

## 1. Problem Restatement

Design a RESTful web service for **students to rate professors** (1–5 stars). Modules taught by different professors across years/semesters; multiple professors can co-teach.

**Key constraints**:
- Admin adds modules/professors via **admin site** (no API needed for those).
- Users **register** (username, email, password) and **login** to rate.
- **Module instance** = module + year + semester + one or more professors.
- Overall professor rating = average of all ratings across all module instances, **rounded to nearest integer**.
- All filtering and calculations on **server**; client only displays.
- Academic year given by first year only (e.g. 2018 for 2018–19).

## 2. Database Design (Django Models)

```python
from django.db import models
from django.contrib.auth.models import User  # built-in

class Professor(models.Model):
    prof_id = models.CharField(max_length=10, unique=True)  # e.g. "JE1"
    name = models.CharField(max_length=100)

    def __str__(self):
        return self.name

class Module(models.Model):
    code = models.CharField(max_length=10, unique=True)  # e.g. "CD1"
    name = models.CharField(max_length=200)

    def __str__(self):
        return f"{self.code}: {self.name}"

class ModuleInstance(models.Model):
    module = models.ForeignKey(Module, on_delete=models.CASCADE)
    year = models.IntegerField()  # e.g. 2018
    semester = models.IntegerField()  # 1 or 2
    professors = models.ManyToManyField(Professor)  # co-teaching

    class Meta:
        unique_together = ('module', 'year', 'semester')

    def __str__(self):
        return f"{self.module.code} ({self.year} S{self.semester})"

class Rating(models.Model):
    user = models.ForeignKey(User, on_delete=models.CASCADE)
    module_instance = models.ForeignKey(ModuleInstance, on_delete=models.CASCADE)
    professor = models.ForeignKey(Professor, on_delete=models.CASCADE)
    score = models.IntegerField()  # 1-5
    created_at = models.DateTimeField(auto_now_add=True)

    class Meta:
        unique_together = ('user', 'module_instance', 'professor')  # one rating per user per prof per instance
```

**Relationships explained**:
- `ModuleInstance` links a `Module` to a specific year/semester and **many professors** (ManyToManyField).
- `Rating` links a `User`, a `ModuleInstance`, and a `Professor` – because a module instance may have multiple professors, the student rates each professor separately.

## 3. API Endpoint Design

| Method | Endpoint | Description | Authentication |
|--------|----------|-------------|----------------|
| `POST` | `/api/register/` | Create new user | None |
| `POST` | `/api/login/` | Login, return token | None |
| `GET` | `/api/module-instances/` | List all module instances with professors | Optional (but rating needs login) |
| `GET` | `/api/professors/` | List all professors with overall rating | Optional |
| `GET` | `/api/professors/{id}/rating/` | Get overall rating of a professor | Optional |
| `GET` | `/api/modules/{code}/professors/{id}/rating/` | Get average rating of a professor in a specific module | Optional |
| `POST` | `/api/ratings/` | Submit a rating (requires login) | Required |

### 3.1 Example Request/Response

**GET `/api/module-instances/`** → returns JSON:
```json
[
  {
    "module_code": "CD1",
    "module_name": "Computing for Dummies",
    "year": 2017,
    "semester": 1,
    "professors": [
      {"id": "JE1", "name": "Professor J. Excellent"},
      {"id": "VS1", "name": "Professor V. Smart"}
    ]
  },
  {
    "module_code": "CD1",
    "year": 2018,
    "semester": 2,
    "professors": [{"id": "JE1", "name": "Professor J. Excellent"}]
  }
]
```

**POST `/api/ratings/`** (authenticated, token in header):
```json
{
  "module_code": "CD1",
  "year": 2018,
  "semester": 2,
  "professor_id": "JE1",
  "score": 4
}
```

**Response**:
```json
{
  "status": "success",
  "message": "Rating submitted"
}
```

**GET `/api/professors/JE1/rating/`** → average rounded:
```json
{
  "professor_id": "JE1",
  "average_rating": 4
}
```

### 3.2 View Function Pseudocode (Django-style)

```python
from django.http import JsonResponse
from django.views.decorators.csrf import csrf_exempt
from django.contrib.auth.decorators import login_required
from django.db.models import Avg
import json

@login_required
@csrf_exempt
def submit_rating(request):
    if request.method == 'POST':
        data = json.loads(request.body)
        # lookup module instance
        instance = ModuleInstance.objects.get(
            module__code=data['module_code'],
            year=data['year'],
            semester=data['semester']
        )
        professor = Professor.objects.get(prof_id=data['professor_id'])
        rating = Rating.objects.create(
            user=request.user,
            module_instance=instance,
            professor=professor,
            score=data['score']
        )
        return JsonResponse({'status': 'success'})

def professor_rating(request, prof_id):
    if request.method == 'GET':
        avg = Rating.objects.filter(professor__prof_id=prof_id).aggregate(Avg('score'))['score__avg']
        rounded = round(avg) if avg else 0
        return JsonResponse({'professor_id': prof_id, 'average_rating': rounded})
```

## 4. Exam Notes for Scenario Questions

- **Always identify relationships** correctly (ForeignKey, ManyToManyField).
- **Admin site** – Django provides automatically; used for manual data entry of modules/professors.
- **Authentication** – use `@login_required` decorator; token-based for REST (e.g. DRF).
- **Calculations on server** – use Django aggregation (`Avg`, `Count`, `Sum`).
- **Rounding** – `round()` in Python (banker's rounding) or `int(avg + 0.5)` for nearest integer.
- **Unique together** – ensure a user cannot rate the same professor in the same module instance twice.

---

# Lecture 9: Web Crawling

## 1. Scale of the Web

- Estimated **>50 billion pages**; only **~5 billion visible** (tip of the iceberg).
- **Deep web (invisible/hidden)** – pages not linked from publicly accessible pages, behind forms, paywalls, login.

**Exam trap (2020 Q1.12)**: "The invisible web forms a very small part of the entire WWW" – **False** (it is much larger than the surface web).

## 2. Web Crawler Basics

> A **web crawler (spider)** is an automated program that downloads web pages by following hyperlinks, enabling search engines to build an index.

**Crawling as graph traversal** – the web is a huge directed graph. Typically **breadth-first** traversal.

**Crawler loop**:
1. Start with **seed URLs**.
2. Add seeds to **URL queue**.
3. Take a URL from queue, download page.
4. Parse page for **link tags** (`<a href="...">`).
5. If new URL (not seen before), add to queue. The set of URLs in queue = **frontier**.
6. Repeat.

## 3. Politeness Policies

> To avoid overloading servers, crawlers implement **politeness**: no more than one request at a time per server, and wait a **politeness window** (e.g. 30 seconds) between requests to the same server.

**Implementation**: Split frontier into **per-server queues**. Crawler only reads from a queue if the server has not been accessed within the politeness window.

**Peak throughput calculation** (2019 Q3):
```
Max pages/sec = (number of distinct servers) / (politeness window in seconds)
```
**Example**: 30,000 servers, 60 sec window → 30,000/60 = 500 pages/sec. If crawler capacity is 600 pages/sec, **cannot achieve peak** (needs more distinct servers).

## 4. `robots.txt`

> File placed at `https://example.com/robots.txt` to instruct crawlers which paths are disallowed. It is **not a detection method** – it is a voluntary compliance mechanism.

**Format**:
```
User-agent: *                      # applies to all crawlers
Disallow: /private/
Disallow: /confidential/
Allow: /other/public/              # exception to disallow
Crawl-delay: 5                     # non-standard: seconds between requests
Sitemap: http://example.com/sitemap.xml
```

- `User-agent` line identifies crawler (e.g. `Googlebot`). `*` means all.
- `Disallow: /` blocks everything; `Disallow:` (empty) allows everything.

**Exam trap (2019 Q1b)**: "Web robots are detected when they download robots.txt" – **False** (downloading robots.txt is normal, not detection).

## 5. Robot Detection & Blocking

Servers detect unwanted crawlers via:

| Detection Method | Description |
|------------------|-------------|
| **Quick successive requests** | Obvious sign of bad robot |
| **Monotonous request rate** | Regular, predictable timing |
| **Trap links** | Hidden links (e.g. CSS `display:none`) that humans don't click; naive robots follow them |
| **Fictitious resources** | Infinite sequence (e.g. `/page/1`, `/page/2`, ...) – robots can go into infinite recursion; mitigation: **maximum depth limit** |
| **User-Agent blacklisting** | Known bot names blocked; robots can **spoof** (change User-Agent) |

**Signs your robot is being blocked**:
- CAPTCHA pages
- Unusual content delivery delay
- Frequent HTTP status codes: **401 Unauthorized, 403 Forbidden, 404 Not Found, 408 Timeout, 429 Too Many Requests, 503 Service Unavailable** (also 301/302 redirections to trap pages)

**Exam trap (2020 Q2s)**: "Which is an indication your robot is being blocked? A. Very long content delivery delay. B. CAPTCHA pages. C. Frequent appearance of 401,403,404,408,429. D. **All of the above**" – Answer **D**.

**Exam trap (2020 Q2k)**: "Which is NOT a feature of a badly designed robot? A. Quick requests. B. Failure to read robots.txt. C. **Failure to set Accept header**. D. Monotonous rate." – Answer **C** (Accept header missing is not inherently bad; others are signs of bad design).

## 6. Sitemaps

> `sitemap.xml` – an XML file listing URLs of a site, with metadata: `lastmod`, `changefreq`, `priority`. Helps crawlers discover pages (including deep web pages behind forms). **Default priority = 0.5**.

```xml
<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">
  <url>
    <loc>http://example.com/</loc>
    <lastmod>2008-01-15</lastmod>
    <changefreq>monthly</changefreq>
    <priority>0.7</priority>
  </url>
</urlset>
```

**changefreq values**: `always`, `hourly`, `daily`, `weekly`, `monthly`, `yearly`, `never`.

**Exam trap (2020 Q2q)**: "Default value of priority tag is **0.5**."

## 7. Maintaining Freshness

- Web pages change over time; crawlers must **revisit** to keep index fresh.
- **HEAD request** (returns headers only, no body) can check `Last-Modified` header without downloading full page.
- **ETag** (entity tag) also used for change detection.
- Crawlers can learn change frequency and schedule revisits accordingly.

## 8. Distributed Crawling

> Crawling the entire web requires **multiple computers** (distributed crawling). Reasons:
> 1. Put crawler **closer** to sites (geographic distribution).
> 2. **Reduce** the size of frontier and visited list per node.
> 3. **Reduce** individual computing resources (CPU, bandwidth).

**Exam trap (2020 Q2t)**: "We use distributed crawling to: A. Find pages in invisible web. B. **Put the crawler closer to the sites it crawls**. C. Reduce cost. D. Avoid detection." – Answer **B** (primary reason; cost reduction is secondary).

## 9. The Conversion Problem

> Search engines index text, but documents come in **hundreds of file formats** (PDF, Word, RTF, ODF, etc.). They must be **converted** to a tagged text format (HTML/XML) to preserve **structural hints** (headings, bold text) that are useful for ranking.

Stripping to plain text loses important information (e.g. title, headings, bolded terms that often describe content).

## 10. Past Paper Calculations & Traps for Lecture 9

| Question                                             | Answer                                      |
| ---------------------------------------------------- | ------------------------------------------- |
| Crawler peak capacity vs politeness window (2019 Q3) | Calculate distinct servers / window seconds |
| robots.txt is for detection?                         | **False** (it's for permission)             |
| Invisible web is very small?                         | **False**                                   |
| Default sitemap priority                             | **0.5**                                     |
| Which status codes indicate blocking?                | 401, 403, 404, 408, 429, 503                |
| Distributed crawling primary purpose                 | Put crawler closer to sites                 |
# Lecture 10: Link Analysis & PageRank Algorithm

## 1. Why Link Analysis?

> The web has billions of pages, many with little useful content. Only a few pages containing a search term are **popular and useful** to most people. **Links** determine which pages are referenced by others, so we can use links to **rank web pages**.

## 2. Anchor Text

> **Anchor text** is the clickable text in a hyperlink: `<a href="URL">anchor text</a>`

**Example**: `<a href="http://www.fish.com">tropical fish</a>` – anchor text = `"tropical fish"`

**Why anchor text is useful**: Many queries are short topical descriptions (like anchor text). Anchor text concisely describes the **linked page**’s topic.

**Simple anchor text ranking**: Search all links for anchor text matching the user’s query; each match adds 1 to the destination page’s score. **Problems**:
- Queries like `"click here"` break the approach.
- Does not consider the **rank of the source page**.

**Better approach**: Use anchor text as an **additional text field** for the destination page.

## 3. Simple Link Analysis (In-Degree)

> The simplest ranking: count the number of **incoming links** to a page. More links = more votes of importance.

**Assumption**: Important pages are referenced by many other pages.

**Example** (diagram from lecture): Pages have numbers inside = count of incoming links. Page with highest in-degree gets highest rank.

**Problem with simple link analysis**: Does not consider the **importance (rank) of the source page**. A link from a highly important page should count more than a link from an obscure page.

## 4. PageRank Algorithm

> **PageRank** (used by Google) models a **random web surfer** who clicks links randomly, never getting bored. The probability that the surfer is viewing a given page at any moment is that page’s **PageRank**.

**Key insight**: Popular pages (many incoming links, or links from popular pages) are visited more often.

> **PageRank is a probability value** – the chance that a random surfer is on that page.

### 4.1 Basic PageRank Formula (without “surprise me” button)

For a page `u`:
```
PR(u) = Σ_{v ∈ B_u} PR(v) / L_v
```
- `B_u` = set of pages that **point to** u
- `L_v` = number of **outgoing links** from page v (not counting duplicates)

**Example (3 pages A, B, C)**:
- Links: A → C (A also links to somewhere else? Let’s use lecture example: A has 2 outgoing links (one to C), B has 1 outgoing link (to C), C has no outgoing links shown)
- Actually from lecture: PR(C) = PR(A)/2 + PR(B)/1

**Iterative calculation** (start with equal probabilities: 1/3 each):

| Iteration | PR(A) | PR(B) | PR(C) |
|-----------|-------|-------|-------|
| 0 (initial) | 0.33 | 0.33 | 0.33 |
| 1 | 0.33 | 0.17 | 0.50 |
| 2 | 0.50 | 0.17 | 0.33 |
| 3 | 0.33 | 0.25 | 0.42 |
| ... converges | **0.4** | **0.2** | **0.4** |

**Final**: PR(A)=0.4, PR(B)=0.2, PR(C)=0.4

### 4.2 Problem: Dead Ends (Rank Sinks)

> If a page has **no outgoing links**, the random surfer gets stuck. Pages that form a **loop** also trap the surfer.

**Solution**: Add a **“surprise me” button** (teleportation). At each step, with probability λ (lambda) the surfer jumps to a **random page**; with probability (1−λ) they follow a link.

> Typical value: **λ = 0.15** (15% chance of teleportation, 85% chance of following a link)

### 4.3 PageRank Formula with Teleportation

```
PR(u) = λ/N + (1−λ) × Σ_{v∈B_u} PR(v) / L_v
```
- `N` = total number of pages
- `λ` = teleportation probability (usually 0.15)
- `λ/N` = contribution from the “surprise me” button (equal chance for any page)

**For the 3-page example** (N=3, λ=0.15):
```
PR(C) = 0.15/3 + 0.85 × (PR(A)/2 + PR(B)/1)
```

### 4.4 Handling Rank Sinks in Algorithm

In the iterative algorithm:
- For a page `p` with **outgoing links** (`|Q| > 0`): distribute `(1−λ) × PR(p) / |Q|` to each page it links to.
- For a page `p` with **no outgoing links** (rank sink): treat it as if it links to **all pages** equally – distribute `(1−λ) × PR(p) / N` to every page.

## 5. PageRank Calculation Example from Past Paper (2020 Q2y)

**Given the PageRank formula (without damping – simplified version used in exam)**:
```
PR(u) = Σ_{v∈B_u} PR(v) / L_v
```
(No teleportation, no λ. Sum of PRs = 1.)

**Question**: For a simple web (diagram of three pages A, B, C with specific links), find the PageRanks.

**Typical answer (from 2020 paper)**: PR(C)=0.4, PR(A)=0.4, PR(B)=0.2 → **Option B**

**Method**:
1. Write equations from link structure.
2. Solve linear system (or iterate until convergence).
3. Normalise so sum = 1.

**Exam note**: The exam may give the **simplified formula** (without λ) – check the question. If λ is not mentioned, use the basic formula.

## 6. Key Points for Exam

| Concept | Value / Description |
|---------|---------------------|
| `B_u` | Set of pages that point to `u` |
| `L_v` | Number of outgoing links from page `v` |
| `λ` (lambda) | Teleportation probability; typical = **0.15** |
| `N` | Total number of pages |
| Without teleportation | Risk of **rank sinks** (pages with no outlinks) |
| PageRank is a **probability** | Sum of all PageRanks = 1 |

## 7. Past Paper Traps for Lecture 10

| Statement | Answer |
|-----------|--------|
| Simple link analysis counts incoming links only | **True** (but ignores source importance) |
| PageRank uses anchor text | **False** (PageRank uses link structure, not anchor text; anchor text is separate ranking signal) |
| λ = 0.15 is typical | **True** |
| Without teleportation, pages with no outlinks cause problems | **True** (rank sinks) |
| PageRank values for a small web can be calculated iteratively | **True** |
# Lecture 11: Parsing and Tokenisation

## 1. Tokenisation – Basic Definition

> **Tokenisation** is the process of forming **tokens (words)** from the sequence of characters in a document.

**Simple definition (plain text)**: A word = any sequence of **alphanumeric characters** (letters/digits) terminated by a space or punctuation mark.

**Example**: `"Bigcorp's 2007 bi-annual report"` → simple tokenisation might produce `["Bigcorp", "s", "2007", "bi", "annual", "report"]` (incorrect handling of apostrophe and hyphen).

## 2. Why Tokenisation is Harder for Web Pages

Web pages contain **markup (HTML tags)** and **metadata** (author, date, etc.). Metadata is **not part of the useful text** for searching, but must be separated from content.

**Example HTML snippet**:
```html
<h1>Tropical Fish</h1>
<p>Visit our <a href="shop.html">fish shop</a> today.</p>
```
- `h1` tag indicates heading (important)
- `a` tag contains anchor text `"fish shop"`
- The parser must separate tags from content.

> **Two-pass tokenisation**:
> 1. **First pass**: Identify markup/tags (using an HTML parser like **Beautiful Soup** in Python).
> 2. **Second pass**: Extract useful words from headings, body text, tables, etc.

## 3. Parsing and DOM

> A **parser** interprets document structure based on markup language syntax (syntactic analysis). It produces a language-agnostic representation.

> For HTML, the parser creates a **Document Object Model (DOM)** – a tree structure representing the page’s elements, attributes, and text.

**Exam trap (2019 Q1h)**: "In a search engine, the lexical analyser creates a Document Object Model (DOM) of the page" – **False**. The **parser** (not lexical analyser) creates the DOM. Lexical analysis is tokenisation.

## 4. Document Structure and Ranking Significance

> **Some parts of HTML structure are very significant for ranking**: headings (`<h1>`, `<h2>`), bold (`<b>`), italics (`<i>`), and **anchor text** (the clickable text of a link).

**Example**: A phrase appearing in the main heading, then again in bold in the body, is strong evidence of importance for that page.

**Anchor text**: `<a href="http://example.com">tropical fish</a>` – `"tropical fish"` is likely a good description of the destination page.

**Exam trap (2019 Q1g)**: "A search engine must give text tagged as boldface higher score as a search keyword" – **False**. It is a strong signal, but not mandatory; ranking algorithms vary.

## 5. Challenges in Tokenisation (Exam-Critical)

### 5.1 Small Words (1–2 characters)
Can be important in combinations: `"xp"`, `"pm"`, `"j lo"`, `"world war II"`. **Do not always ignore**.

**Exam trap (2020 Q2m)**: "Which words should a search engine always ignore when tokenizing? A. Small words. B. Hyphenated words. C. Capitalised words. D. **None of the above**." – Answer **D**. It depends on context.

### 5.2 Hyphens
Hyphenated forms may be necessary: `"e-bay"`, `"wal-mart"`, `"cd-rom"`, `"t-shirts"`. Some queries need the hyphen; removing it changes meaning.

### 5.3 Capitalisation
Capitalised words can have different meaning: `"Bush"` (president) vs `"bush"` (shrub); `"Apple"` (company) vs `"apple"` (fruit).

**Tokeniser strategy**: Usually **case-fold** (convert to lowercase) for English to improve recall, but this loses distinction. Many search engines case-fold by default.

**Exam trap (2019 Q1k)**: "The tokeniser in a search engine must not convert capital letters to small letters" – **False**. Most do convert (case-folding).

### 5.4 Apostrophes
Apostrophes can be part of a word (possessives, contractions): `"Rosie O'Donnell"`, `"can't"`, `"80's"`, `"men's straw hats"`. Removing the apostrophe can create a different word.

### 5.5 Numbers and Periods
Numbers matter: `"Nokia 3250"`, `"top 10 courses"`, `"QuickTime 6.5 pro"`. Periods in abbreviations: `"I.B.M."`, `"Ph.D."`, URLs, decimal numbers.

## 6. Stopwords (Function Words)

> **Stopwords** (function words) are common words with little meaning in isolation: `"the"`, `"a"`, `"an"`, `"that"`, `"over"`, `"under"`, `"above"`, `"below"`. Also called **function words**.

**Frequency**: `"the"` appears ~16.5% of all words in English text.

**Pros of removing stopwords**:
- Decreases index size
- Increases retrieval efficiency
- Generally improves effectiveness

**Cons of removing stopwords**:
- Some queries consist entirely of stopwords (e.g. `"to be or not to be"`) – removal would break the query.

**Exam trap (2020 Q1.10)**: "In natural languages, function words are also called stop words" – **True**.

## 7. Stemming (Conflation)

> **Stemming** reduces different word forms (inflectional or derivational) to a **common stem**. For example, `"swimming"`, `"swam"`, `"swims"` → stem `"swim"`.

**Why use stemming**: Allows matching query `"swimming"` with document containing `"swam"`.

**Effectiveness**:
- **English**: small improvement (<5% for large collections, ~10% for domain-specific)
- **Highly inflectional languages** (Arabic, Russian, Spanish): stemming can improve effectiveness by **>50%**.

**Exam trap (2019 Q1l)**: "An English search engine can be 60% more accurate if it uses stemming" – **False**. The improvement is much smaller (single-digit percentages). The 60% figure applies to highly inflectional languages like Arabic.

### 7.1 Types of Stemmers

| Type | Description | Example |
|------|-------------|---------|
| **Algorithmic** | Uses programmed rules (suffix removal) | Porter stemmer |
| **Dictionary-based** | Uses pre-created dictionary of term relationships | Can map `"is"`, `"be"`, `"was"` to same root (algorithmic stemmers cannot) |

**Exam trap (2020 Q2n)**: "An algorithmic stemmer is based on: A. Knowledge of word prefixes and suffixes for a particular language. B. Pre-created dictionaries. C. Both. D. None." – Answer **A**. Algorithmic stemmers use suffix/prefix rules, not dictionaries.

### 7.2 Porter Stemmer Step 1a (Exam Example – 2019 Q4)

Rules (simplified):
- `SSES` → `SS` (e.g. `stresses` → `stress`)
- `IES` → `I` (e.g. `cries` → `cri`; `ties` → `ti`? Actually Porter: if more than one letter before, replace with `i`; else `ie`)
- `S` → delete if preceded by a vowel (e.g. `gaps` → `gap`; but `gas` → `gas` because no vowel before `s`? Actually rule: delete `s` if the word part before contains a vowel not immediately before the `s`)
- `US` or `SS` → do nothing

**Example answers from 2019 Q4**:
- `was` → no change (`was`)
- `grasps` → `grasp` (remove `s`; preceding part `grasp` contains vowel `a`)
- `masses` → `mass` (replace `sses` with `ss` → `mass`)
- `mucus` → no change (`us` ending, do nothing)
- `tries` → `tri` (replace `ies` with `i` because `tr` has more than one letter)

## 8. Phrases and N-grams

> A **phrase** is more precise than single words (e.g. `"tropical fish"` vs `"fish"`) and less ambiguous.

**Common definition in IR**: a simple noun phrase (sequence of nouns, or adjectives followed by nouns). Identified using a **Part-of-Speech (POS) tagger**.

### 8.1 POS Taggers

> A **POS tagger** marks each word with its part of speech (noun, verb, adjective, etc.) based on context. Taggers are **trained on large manually labelled corpora**.

**Common tags**:
- `NN` – singular noun
- `NNS` – plural noun
- `VB` – verb (base form)
- `VBD` – verb (past tense)
- `JJ` – adjective
- `IN` – preposition
- `MD` – modal auxiliary (can, will)
- `PRP` – pronoun

**Example** (from lecture): `"Document will describe marketing strategies"` → tagged as `Document/NN will/MD describe/VB marketing/NN strategies/NNS`

**Exam trap (2019 Q1e)**: "A 'parts of speech' tagger is trained using large collections of documents that have been manually labelled" – **True**.

**Exam trap (2020 Q2q)**: "A stemmer is a program that tags each word with its correct part of speech" – **False** (that’s a POS tagger, not a stemmer).

## 9. Past Paper Traps Summary for Lecture 11

| Statement | Answer | Reason |
|-----------|--------|--------|
| The lexical analyser creates a DOM | **False** | Parser creates DOM |
| Search engine must give boldface higher score | **False** | It’s a signal, not a requirement |
| Tokeniser must not convert capitals to small | **False** | Most do convert (case-folding) |
| Function words = stop words | **True** | Definition |
| English search engine 60% better with stemming | **False** | Improvement is small (~5%) |
| POS tagger trained on manually labelled data | **True** | Supervised training |
| Stemmer tags part of speech | **False** | Stemmer reduces words to stems |
| Words search engine always ignore: small words? | **None of the above** | Depends on query |
| Algorithmic stemmer uses dictionaries? | **False** | Uses suffix/prefix rules |

## 10. Key Equations & Rules for Exam

**Porter Stemmer Step 1a (as given in lecture)**:
- `sses` → `ss`
- Delete `s` if preceding part contains a vowel not immediately before the `s`
- `ied` or `ies` → `i` if preceded by more than one letter, otherwise → `ie`
- `us` or `ss` → do nothing
# Lecture 12: Indexing

## 1. Document Features for Ranking

> To rank documents, search engines transform text into **numerical features**. Two types: **Topical features** (about the subject) and **Quality features** (importance, freshness).

**Topical features**: Estimate degree to which a document is about a particular topic (e.g. term frequency, TF-IDF).

**Quality features**: Estimate importance regardless of query (e.g. number of incoming links, page rank, last update date). A page with no incoming links and not updated for years is probably a poor match for any query.

**Ranking function** (simplified):
```
R(Q, D) = Σ_i g_i(Q) × f_i(D)
```
- `f_i(D)` = feature function from document (e.g. term frequency)
- `g_i(Q)` = feature function from query (e.g. is term in query? related terms?)

**Example**: For query `"tropical fish"`, `g_tropical(Q)` is large (term in query), `g_barb(Q)` might be small non-zero (barb is a type of fish, related).

## 2. Inverted Index – Core Concept

> All modern search engine indices are based on the **inverted index** – the computational equivalent of a book’s back-of-the-book index.

**Forward index** (document → words): Not used for querying.  
**Inverted index** (word → list of documents): Enables fast lookup.

**Structure**:
- Each **index term** has an **inverted list** (postings list).
- Each entry in the list is a **posting** (points to a document).
- Documents are assigned **unique numeric IDs** (not URLs) for efficiency. A separate mapping links doc IDs to URLs.
- Terms are often stored in a **hash table** for O(1) lookup.

**Example (book index style)**:
```
fluid, 25
amplitude, 26
Bessel function, 30
```
→ term `"amplitude"` appears on page 26.

## 3. Types of Inverted Indices (Increasing Information)

### 3.1 Document Numbers Only
Simplest form: stores just the document IDs that contain each term.

**Use**: Boolean retrieval (find documents containing all query terms).  
**Limitation**: Cannot rank by term frequency or phrase matching.

### 3.2 With Word Counts (Term Frequency)
Each posting stores: `(docID, term_frequency)`

**Why useful**: Word counts help distinguish documents that are **about** a subject from those that mention it in passing. Higher frequency → more relevant.

**Example**: Query `"tropical fish"`. Document S2 contains `"tropical"` twice and `"fish"` three times → higher score than S1 (once each).

### 3.3 With Word Positions (for Phrase Queries)
Each posting stores: `(docID, [position1, position2, ...])`

**Why useful**: Determine if a document contains an **exact phrase** (e.g. `"tropical fish"`). Positions must be consecutive.

**Example**: For `"tropical"` at position 4, `"fish"` at position 5 in same document → phrase match.

**Exam trap (2020 Q2p)**: "Which type of inverted index can result in the best phrase matches? A. Document numbers only. B. Document numbers and word positions. C. Document numbers and word counts. D. All equally good." – Answer **B**.

### 3.4 With Fields and Extents (Structural Information)
> An **extent** is a contiguous region of a document (e.g. title, heading) represented by word position ranges `(start, end)`.

**Why useful**: Words in **titles, headings, bold text** are more important than body text.

**Example**: Store title extent as positions (5,9). Then only count `"fish"` if its position falls within that range.

### 3.5 Precomputed Scores (Direct Feature Values)
Each posting stores a **precomputed feature value** (e.g. `(docID, 3.6)` where 3.6 combines TF, title presence, bold, anchor text, related terms).

**Pros**: Enables computationally expensive scoring that would be too slow during query processing.

**Cons**:
- **Loses flexibility**: Cannot change scoring mechanism after index is built.
- **Loses proximity information**: Cannot support phrase queries unless phrase lists are also precomputed (which takes huge space).

## 4. Physical Storage of Inverted Indices

### 4.1 Naïve Approach: One File per Term
Store each inverted list as a separate file named after the term.

**Problems**:
- Millions of tiny files. File systems reserve **~1KB per file** (even if file contains 30 bytes).
- **Wasted space**: Example – 70,000 unique terms, each occurring once, 30 bytes per posting. Actual data = 2MB, but file system allocates 70,000 × 1KB = 70MB.
- Directory lookups can be slow.

### 4.2 Standard Approach: Single Inverted File + Vocabulary Lexicon
- Store **all inverted lists concatenated** in one large **inverted file**.
- Maintain a separate **vocabulary (lexicon)** – a lookup table mapping each term to the **byte offset** where its inverted list starts in the file.
- Vocabulary is small enough to fit in memory (hash table for O(1) lookup). For very large vocabularies, use a **tree-based structure** (e.g. B-tree) to minimise disk accesses.

**This is why it’s called an “inverted file”** – all lists in one file.

## 5. Retrieval Algorithms: Document-at-a-Time vs Term-at-a-Time

**Exam relevance (2020 Q2r)**: "In a real search engine, which retrieval algorithm is better in terms of memory use? A. Document-at-a-time. B. Term-at-a-time. C. Roughly equal but require optimisation. D. Roughly equal and do not require optimisation." – Answer **C** (roughly equal but require optimisation).

**Document-at-a-time**: Process one document at a time, accumulating scores from all query terms. Memory usage per document.

**Term-at-a-time**: Process one term at a time, accumulating contributions to all documents. Memory usage for score array of size N (number of documents). Both have trade-offs; real engines optimise.

## 6. Skip Pointers (Exam Revisited)

> **Skip pointers** are additional links within a posting list that allow jumping ahead during query processing (like skipping pages in a book index).

**Exam trap (2019 Q1m)**: "If we add skip pointers to an inverted list, we can achieve a substantial improvement in the asymptotic performance of search operations" – **False**. Skip pointers improve **practical speed** but do **not** change asymptotic complexity (still O(n) in list length). However, they are still worth using.

**Exam trap (2020 Q2o)**: "Using skip pointers to locate a term in a large list: A. Improves asymptotic running time. B. Does not improve asymptotic time, hence should not be used. C. **Does not improve asymptotic time, yet can lead to significant running time improvements hence should be used.** D. Increases running time." – Answer **C**.

## 7. Past Paper Traps for Lecture 12

| Statement | Answer | Reason |
|-----------|--------|--------|
| The simplest inverted index stores document numbers only | **True** | But cannot support phrase queries |
| Word positions are needed for phrase matching | **True** | To check consecutive positions |
| Storing precomputed scores increases flexibility | **False** | It decreases flexibility (can't change scoring) |
| Skip pointers improve asymptotic performance | **False** | They improve practical speed, not asymptotic |
| Inverted indices are stored as one file per term | **False** | That wastes space; standard is a single inverted file with lexicon |
| Vocabulary lexicon maps terms to byte offsets | **True** | Enables fast lookup in the inverted file |
# Lecture 13: Query Processing

## 1. The Ranking Function (Recap)

For a document `D` and query `Q`, the ranking score is:

```
R(Q, D) = Σ_i g_i(Q) × f_i(D)
```
- `f_i(D)` = document feature (e.g. term frequency, inverse document frequency)
- `g_i(Q)` = query feature (e.g. 1 if term `i` is in Q, or related term weight)

**Example**: Query `"tropical fish"`. `g_tropical(Q)` is large (term in query). `g_barb(Q)` might be small non-zero because `"barb"` is a type of fish (related term). Quality features (incoming links, freshness) also have corresponding `g` and `f` functions.

## 2. Document-at-a-Time (DAAT) Evaluation

> **Document-at-a-time** scores documents one by one. For each document, it sums contributions from all query term posting lists that contain that document.

**Visual analogy**: Inverted lists aligned vertically; each column = one document. Process column 1 (all terms), then column 2, etc.

**Pseudocode summary**:
- Get inverted lists for all query terms.
- Loop over **all documents** (or over documents that appear in any list).
- For current document `d`, add contribution from each list if its current posting is for `d`.
- Move each list past `d` (advance to next posting).
- Keep top `k` results in a **priority queue** (size `k`).

**Memory advantage**: Only needs priority queue for `k` documents (e.g. `k=10`). Very low memory.

**Disk access disadvantage**: Jumps between lists frequently; requires large list buffers to reduce seeking.

## 3. Term-at-a-Time (TAAT) Evaluation

> **Term-at-a-time** processes one query term’s entire inverted list at a time, accumulating scores into an **accumulator table** (one entry per document that appears in any list).

**Pseudocode summary**:
- Get inverted lists for all query terms.
- For each list `l_i`:
  - Walk through every posting in `l_i`.
  - For each posting `(docID, feature_value)`, add `g_i(Q) × feature_value` to accumulator `A[docID]`.
- After all terms processed, extract top `k` accumulators.

**Memory disadvantage**: Accumulator table `A` can be as large as the number of distinct documents appearing in any list (potentially millions). Requires hash table or array.

**Disk access advantage**: Reads each inverted list sequentially from start to finish → minimal disk seeking, very efficient.

## 4. DAAT vs TAAT Comparison

| Aspect | Document-at-a-Time | Term-at-a-Time |
|--------|--------------------|----------------|
| **Memory** | Low (only top-k queue) | High (accumulator table) |
| **Disk seeks** | High (jumps between lists) | Low (sequential reads) |
| **Typical use** | When memory is constrained | When disk seeks are expensive |
| **Optimisation** | Requires large list buffers | Requires compressed accumulators |

**Exam trap (2020 Q2r)**: "In a real search engine, which retrieval algorithm is better in terms of memory use? A. Document-at-a-time. B. Term-at-a-time. C. Roughly equal but require optimisation. D. Roughly equal and do not require optimisation." – **Answer C**. Both are used with optimisations; neither is strictly better without tuning.

## 5. Conjunctive Processing (AND queries)

> **Conjunctive processing** requires that **every document returned contains all query terms**. Default mode for many web search engines (users expect all terms to appear).

**Key optimisation**: Process terms in order of **increasing frequency** (rarest term first).

**Example**: Query `"galago AND animal"`.  
- `"galago"` occurs in ~1 million documents.  
- `"animal"` occurs in ~300 million documents.  
- Rare term `"galago"` is the **driver**.

**Simple merge algorithm** (both lists sorted by docID):
```
let d_g = first docID in galago list
let d_a = first docID in animal list
while (both lists not exhausted):
    if d_a == d_g:
        output match; advance both
    else if d_a < d_g:
        advance animal list
    else: # d_g < d_a
        advance galago list
```
**Problem**: This processes almost all 300M animal postings, 99% of which do not contain `"galago"` – very expensive.

## 6. Skip Pointers for List Skipping

> **Skip pointers** are additional links inserted at regular intervals in a posting list, allowing the algorithm to jump ahead without reading every posting.

**How skipping works**:
- When `d_a < d_g`, instead of moving one step in animal list, skip ahead `k` postings to `s_a`.
- If `s_a < d_g`, skip another `k`, narrowing the range.
- Then linearly search within a small block.

**Skip pointer structure**: Grey boxes (skip pointers) point to later white boxes (postings). Stored as `(target_docID, byte_offset)`.

### 6.1 Skip Pointers Do Not Improve Asymptotic Complexity

> Adding skip pointers does **not** change the **asymptotic** (big-O) running time – still O(n) for list of length n. However, practical speedup is huge (factor of 10–100).

**Exam trap (2019 Q1m)**: "Skip pointers improve asymptotic performance" – **False**.  
**Exam trap (2020 Q2o)**: "Using skip pointers: A. Improves asymptotic time. B. Does not improve asymptotic time, hence should not be used. C. Does not improve asymptotic time, yet gives significant improvements – should be used. D. Increases time." – **Answer C**.

### 6.2 Skip Pointer Optimisation (Cost Model)

**Parameters**:
- `n` = list length (bytes)
- `k` = skip pointer size (bytes, e.g. 4)
- `c` = interval between skip pointers (bytes)
- `p` = number of postings we need to find (unknown at query time)

**Bytes read** = `(k × n)/c + (p × c)/2`
- First term: reading the skip pointers themselves.
- Second term: reading half an interval on average for each target posting.

**Trade-off**: Larger `c` reduces first term (fewer skip pointers) but increases second term (larger intervals to scan). Optimal `c` depends on `p` (unknown). Systems learn from past queries to estimate best `c`.

## 7. Practical Optimisations

- **Early termination**: Stop processing once top-k scores are stable.
- **Max score pruning**: Skip documents that cannot reach top-k even with maximum possible contributions.
- **Caching**: Frequently used posting lists kept in memory.
- **Compression**: Posting lists stored with variable-byte encoding or delta encoding.

**Exam note**: Real search engines use **neither pure DAAT nor pure TAAT without optimisations**. They combine techniques.

## 8. Past Paper Traps for Lecture 13

| Statement | Answer | Reason |
|-----------|--------|--------|
| DAAT uses less memory than TAAT | **True** | DAAT only needs top-k queue |
| TAAT has better disk access pattern | **True** | Sequential reads |
| Conjunctive processing requires all query terms | **True** | Definition |
| Process rarest term first in conjunctive queries | **True** | Minimises work |
| Skip pointers improve asymptotic complexity | **False** | Still O(n) but huge constant factor improvement |
| Skip pointers should not be used | **False** | They give significant practical speedups |
# Lecture 14: Linked Data

## 1. Motivation – The Inspector Gadget Problem

> How can we answer the question: **“Did my teacher go to Finland?”**  
> This requires integrating data from multiple sources: teacher’s profile, travel records, country definitions. Traditional web (documents for humans) makes this hard.

**Limitation of the traditional WWW**:
- A collection of **documents** with little structure (images, free text).
- Data in many formats: HTML, PDF, CSV, Excel, Word tables.
- Formatted for **human consumption**, not automated processing.
- Only humans can easily analyse **semantic relationships** across pages.

## 2. Linked Data – Definition

> **Linked Data** refers to a set of techniques for **publishing and connecting structured data** on the Web. It adheres to standards set by the **W3C**.

**Exam trap (2020 Q1.13)**: "Linked Data refers to a set of techniques for publishing and connecting structured data on the Web" – **True**.

**Goal**: Enable **automated agents** to access the Web intelligently and perform complex queries on behalf of users.

## 3. The Semantic Web

> When elements of the web are **structured data entities** connected by **semantic relations**, the resulting graph is called the **Semantic Web**.

**Contrast**: Traditional web = documents linked by hyperlinks. Semantic web = **things (entities)** linked by **relationships**.

## 4. RDF – Resource Description Framework

> **RDF** (Resource Description Framework) is the **data model** for Linked Data. It uses an **Entity-Attribute-Value (EAV)** model, also called **subject–predicate–object** triples.

**Triple structure**:
- **Subject** – the resource being described (URI)
- **Predicate** – the attribute or relationship (URI)
- **Object** – the value (literal or another resource URI)

**Example** (book cover facts):
```
<http://example.com/book>  <http://purl.org/dc/elements/1.1/title>  "Linked Data, structured data on the Web" .
<http://example.com/book>  <http://purl.org/dc/elements/1.1/creator>  <http://example.com/person/david-wood> .
```
- Subject: the book URI
- Predicate: `dc:title` (attribute)
- Object: literal string (title)
- Second triple: subject same book, predicate `dc:creator`, object another resource (author’s URI)

**Exam trap (2020 Q2u)**: "In RDF, the attribute of an entity is also called: A. The predicate. B. The object. C. The value. D. None." – **Answer A (predicate)**.

### 4.1 RDF Diagram (Graph Representation)

RDF triples form a **directed graph**:
- Subjects and objects = **nodes** (circles/rectangles)
- Predicates = **edges** (arrows labelled with predicate URI)

**Example**: Bonobo is a mammal.
```
dbpedia:Bonobo  rdf:type  dbpedia-owl:Mammal .
```
Diagram: node `dbpedia:Bonobo` → arrow labelled `rdf:type` → node `dbpedia-owl:Mammal`.

**Exam trap (2020 Q2v)**: "Which RDF statement is NOT correct for 'bonobo is a mammal'?  
A. `dbpedia:Bonobo rdf:type dbpedia-owl:Mammal` (correct)  
B. `dbpedia:Bonobo a dbpedia-owl:Mammal` (correct – `a` is shorthand for `rdf:type`)  
C. `rdf:type dbpedia:Bonobo dbpedia-owl:Mammal` (incorrect – subject must come first)  
D. All are correct" – **Answer C**.

### 4.2 Predicates are Discoverable

> Anytime you want to know what a predicate means, you can **type its URI into a web browser** and look up its definition (e.g. in an RDF schema or ontology).

**Example**: `http://xmlns.com/foaf/0.1/knows` – FOAF (Friend of a Friend) vocabulary defines `knows` as a relationship between people.

## 5. RDF Serialisation Formats

| Format | Description | Example |
|--------|-------------|---------|
| **RDF/XML** | XML syntax (verbose, older standard) | `<rdf:Description rdf:about="...">` |
| **Turtle** (Terse RDF Triple Language) | Human-readable, compact | `@prefix foaf: <http://xmlns.com/foaf/0.1/> .` |
| **JSON-LD** | JSON-based, popular for web APIs | `{"@context": {...}, "@id": "..."}` |

**Turtle example** (Star Wars data):
```turtle
@base <http://example.com/starwars/> .
@prefix foaf: <http://xmlns.com/foaf/0.1/> .
@prefix rel: <http://purl.org/vocab/relationship/> .

<me> a foaf:Person ;
      foaf:givenname "Anakin" ;
      foaf:family_name "Skywalker" ;
      foaf:nick "Darth Vader" ;
      rel:Spouse_Of <padmeamidala> .
```
- `a` is shorthand for `rdf:type`.
- Semicolon `;` separates multiple predicates for the same subject.

## 6. DBpedia – Linked Data from Wikipedia

> **DBpedia** extracts structured data from Wikipedia **infoboxes** and publishes it as RDF. One of the largest Linked Open Data datasets.

**Scale** (2016 release): 6 million entities, including 1.5 million persons, 800,000 places, 135,000 music albums, 100,000 films. Today > 228 million entities.

**Example DBpedia URIs**:
- `http://dbpedia.org/resource/London`
- `http://dbpedia.org/resource/United_Kingdom`

**Properties**: `dbo:capital`, `dbo:population`, `dbo:country`, etc.

## 7. Linked Open Data (LOD) Cloud

> The **LOD cloud** is the collection of Linked Data datasets published on the Web, connected by links (RDF triples where subject and object are from different datasets).

**Key facts** (from lecture, approximate historical numbers):
- Doubled every 10 months since 2007.
- > 1,500 datasets currently.
- Over 30 billion triples, > 500 million links.
- Major contributors: governments (UK, US) – 40%; geographical data – 22%; life sciences – 10% (but >50% of links).

**Open data**: Freely available for anyone to use, under open licenses.

**Exam note**: Linked Data + Open Data = **Linked Open Data** (LOD). The LOD cloud visualisation shows datasets as circles, links as arrows.

## 8. SPARQL – Query Language for RDF

> **SPARQL** (SPARQL Protocol and RDF Query Language) is the SQL-like query language for RDF graphs.

**Basic query pattern**:
```sparql
SELECT ?subject ?object
WHERE {
  ?subject ?predicate ?object .
  ?subject rdf:type dbpedia-owl:Person .
  ?subject dbpedia-owl:birthPlace dbpedia:Leeds .
}
```
- Variables start with `?` (e.g. `?subject`, `?name`).
- Triple patterns match against RDF data.

**Exam trap (2020 Q2w)**: "Which is a correct SPARQL query to find any 'subject' related to Leeds?  
A. `SELECT ?sub WHERE { ?sub ?pred :Leeds. }`  
B. `SELECT ?entity WHERE { ?entity ?pred :Leeds. }`  
C. `SELECT ?sub WHERE { ?sub ?predicate :Leeds. }`  
D. **All of the above**" – Answer **D** (variable names don’t matter; pattern is the same).

**Exam trap (2020 Q2x)**: "Find the name of any person born in Leeds.  
A. `SELECT ?name WHERE { ?name foaf:name ?name. ?name dbo:birthPlace :Leeds. }` (incorrect – same variable used for name and person)  
B. `SELECT ?name WHERE { ?entity foaf:name ?name. ?entity dbo:birthPlace :Leeds. }` (correct)  
C. `SELECT ?name WHERE { ?entity foaf:name ?name. ?name dbo:birthPlace :Leeds. }` (incorrect – `?name` is a literal, cannot have birthPlace)  
D. `SELECT ?name WHERE { ?entity foaf:name ?Leeds. ?name dbo:birthPlace :Leeds. }` (incorrect)" – Answer **B**.

## 9. RDF Diagram Drawing (Exam 2019 Q2)

You may be asked to draw an RDF diagram from a textual description.

**Example** (2019 Q2): "The United Kingdom comprises four countries: England (capital London), Wales (capital Cardiff), Scotland (capital Edinburgh), Northern Ireland (capital Belfast). London also capital of UK, population 8 million. English official language of England; English and Welsh official in Wales."

**How to draw**:
- **Subjects** (resources): `:UnitedKingdom`, `:England`, `:Wales`, `:Scotland`, `:NorthernIreland`, `:London`, `:Cardiff`, `:Edinburgh`, `:Belfast`.
- **Predicates**: `:comprises`, `:hasCapital`, `:hasPopulation`, `:officialLanguage`.
- **Objects**: literals for population (8 million) and languages ("English", "Welsh").
- Nodes as circles/ellipses, edges as arrows labelled with predicate names.

**RDF triples from description**:
```
:UnitedKingdom :comprises :England, :Wales, :Scotland, :NorthernIreland .
:England :hasCapital :London .
:Wales :hasCapital :Cardiff .
:Scotland :hasCapital :Edinburgh .
:NorthernIreland :hasCapital :Belfast .
:UnitedKingdom :hasCapital :London .
:London :hasPopulation "8000000"^^xsd:integer .
:England :officialLanguage "English" .
:Wales :officialLanguage "English", "Welsh" .
```

## 10. Key Vocabulary Prefixes (Exam-Relevant)

| Prefix | URI | Use |
|--------|-----|-----|
| `rdf:` | `http://www.w3.org/1999/02/22-rdf-syntax-ns#` | `rdf:type` |
| `rdfs:` | `http://www.w3.org/2000/01/rdf-schema#` | `rdfs:label`, `rdfs:comment` |
| `foaf:` | `http://xmlns.com/foaf/0.1/` | Friend of a Friend (people, names, knows) |
| `dbo:` / `dbpedia-owl:` | `http://dbpedia.org/ontology/` | DBpedia ontology |
| `rel:` | `http://purl.org/vocab/relationship/` | Relationships (e.g. `Spouse_Of`) |

## 11. Past Paper Traps for Lecture 14

| Statement | Answer | Reason |
|-----------|--------|--------|
| Linked Data refers to techniques for publishing structured data on the Web | **True** | Definition |
| The semantic web is a graph of structured data entities with semantic relations | **True** | |
| RDF uses subject-predicate-object triples | **True** | |
| In RDF, the attribute of an entity is called the object | **False** | It is the **predicate** |
| The predicate in an RDF statement defines attributes of the object (2019 Q1j) | **False** | Defines attribute of the **subject** |
| A SPARQL query variable must be named `?subject` | **False** | Any name with `?` prefix |
| DBpedia extracts data from Wikipedia infoboxes | **True** | |
| The LOD cloud contains only government data | **False** | Many domains (geography, life sciences, media, publications) |
# Lecture 15: RDF – Resource Description Framework (Detailed)

## 1. RDF Triple – Subject, Predicate, Object

> **RDF** represents knowledge as **triples**: `(subject, predicate, object)`. This is also called the **Entity-Attribute-Value (EAV)** model.

**Subject** – the resource being described.
- Must be a **resolvable URI** (web URL). Requesting the URL should return information about the subject.
- **Exam trap (2020 Q1.14)**: "The subject in an RDF statement must be a resolvable URI" – **True** (in proper Linked Data practice).

**Predicate** – the attribute or relationship.
- Must have its own **resolvable URI**.
- **Resolving a predicate**: typing its URI into a browser returns a human-readable definition (e.g. `http://purl.org/dc/elements/1.1/creator` returns description: “An entity primarily responsible for making the resource”).
- **Exam trap (2019 Q1j)**: "The predicate in an RDF statement defines attributes of the object" – **False** (it defines attributes of the **subject**).

**Object** – the value.
- Can be a **resolvable URI** (another resource) or a **literal** (string, number, date, etc.).
- Literals can have language tags (`"Hello"@en`) or datatypes (`"25"^^xsd:integer`).

## 2. URL Abbreviations (Prefixes)

> To save space, URIs are abbreviated as **prefix:suffix**. The prefix expands to a base URI.

**Common prefixes**:
| Prefix | URI | Purpose |
|--------|-----|---------|
| `rdf:` | `http://www.w3.org/1999/02/22-rdf-syntax-ns#` | RDF syntax |
| `rdfs:` | `http://www.w3.org/2000/01/rdf-schema#` | RDF Schema (classes, properties) |
| `foaf:` | `http://xmlns.com/foaf/0.1/` | Friend of a Friend (people, names, knows) |
| `dc:` | `http://purl.org/dc/elements/1.1/` | Dublin Core (title, creator, date) |
| `vcard:` | `http://www.w3.org/2006/vcard/ns#` | Contact information |

**Example**: `dc:creator` means `http://purl.org/dc/elements/1.1/creator`.

## 3. Blank Nodes

> **Blank nodes** (anonymous resources) are used when you need to describe a resource that doesn’t have a URI. They are written as `_:nodeID` or `[]`.

**Example** (a person with unknown URI):
```turtle
_:alice foaf:name "Alice" .
_:alice foaf:knows <http://example.com/bob> .
```

**Problems with blank nodes**:
- Cannot be referenced from outside the document.
- Difficult to merge data from multiple sources.
- **Avoid using blank nodes whenever possible** (use persistent URIs).

**Skolemization**: Some RDF databases automatically assign URIs to blank nodes to make them addressable.

## 4. Classes and Types

> **Classes** group resources. Use `rdf:type` (or shorthand `a`) to declare that a resource is an instance of a class.

```turtle
:London a :City .
:UnitedKingdom a :Country .
```

- Classes themselves are instances of `rdfs:Class`.
- **Subclass**: `rdfs:subClassOf` indicates that all instances of one class are also instances of another.

```turtle
:City rdfs:subClassOf :Place .
```

**Exam trap**: In RDF diagrams, the `rdf:type` edge is often labelled `type` or `a`.

## 5. RDF Vocabularies (Ontologies)

> An **RDF vocabulary** is a collection of terms (predicates, classes) with defined meanings, published on the Web.

**Anyone can mint a vocabulary**. To make it reusable:
- Reuse existing vocabularies whenever possible (FOAF, DC, vCard, etc.).
- Ensure vocabulary URIs themselves follow Linked Data principles (resolvable, stable).

**LOV (Linked Open Vocabularies)** project collects >800 vocabularies: `https://lov.linkeddata.es/dataset/lov`

**Examples of terms**:
- `rdfs:label` – human-readable name
- `rdfs:comment` – description
- `rdfs:seeAlso` – link to related information
- `foaf:name` – full name of a person
- `vcard:locality` – city or town

## 6. Minting Good URIs (Exam-Relevant)

> When creating your own URIs for Linked Data resources or vocabulary terms, follow these guidelines:

1. **Use a DNS domain you control** (e.g. `http://example.com/`)
2. **Use natural keys** that humans can understand, not random IDs.
   - Good: `http://example.com/baked_goods/bread/rye-12`
   - Bad: `http://example.com/984d6a`
3. **Make URIs neutral to implementation details** (no file extensions like `.aspx`, `.php`, or internal server paths).
   - Good: `http://example.com/people/alice`
   - Bad: `http://example.com/showperson.aspx?id=123`

## 7. Fragment Identifiers (`#`)

> **Fragment identifiers** are the part of a URL after the `#` symbol, e.g. `http://example.com/vocab#person`.

**Key behaviours**:
- Browsers **do not send** the fragment identifier to the server. They request the base URI and then scroll to the fragment.
- For Linked Data, fragments are often used to address a specific term inside a vocabulary document.
- **Should be avoided** for identifying resources in Linked Data (prefer full URIs without fragments, or use hash URIs only when the whole document represents a single resource).

**Exam trap (2020 Q1.15)**: "Fragment identifiers are the part of the URL that follows the @ symbol" – **False** (they follow the **hash `#`** symbol, not `@`).

## 8. RDF Serialisation Formats

> **RDF is a data model, not a format**. Several concrete syntaxes (serialisations) exist.

| Format | Description | Use case |
|--------|-------------|----------|
| **Turtle** (Terse RDF Triple Language) | Human‑readable, compact, uses prefixes | Most common for examples and tutorials |
| **RDF/XML** | Original XML‑based format | Legacy systems |
| **RDFa** | RDF embedded in HTML attributes | Add structured data to web pages (schema.org) |
| **JSON-LD** | JSON‑based, web‑developer friendly | Modern web APIs, easy to parse in JavaScript |

**Turtle example** (previously shown):
```turtle
@prefix foaf: <http://xmlns.com/foaf/0.1/> .
<http://example.com/me> a foaf:Person ;
                         foaf:name "Anakin Skywalker" .
```

**JSON-LD example**:
```json
{
  "@context": {"foaf": "http://xmlns.com/foaf/0.1/"},
  "@id": "http://example.com/me",
  "@type": "foaf:Person",
  "foaf:name": "Anakin Skywalker"
}
```

## 9. Core RDF Vocabularies Table

| Vocabulary | Prefix | Example term |
|------------|--------|---------------|
| RDF | `rdf:` | `rdf:type`, `rdf:Property` |
| RDF Schema | `rdfs:` | `rdfs:label`, `rdfs:comment`, `rdfs:subClassOf` |
| FOAF | `foaf:` | `foaf:name`, `foaf:knows`, `foaf:homepage` |
| Dublin Core | `dc:` | `dc:title`, `dc:creator`, `dc:date` |
| vCard | `vcard:` | `vcard:locality`, `vcard:country-name` |

---

# Lecture 16: RDF Exercises

## 1. Exercise 1: United Kingdom RDF Diagram (2019 Q2 style)

**Statement**: "The United Kingdom comprises four countries: England (whose capital is London), Wales, Scotland, and Northern Ireland. The capitals of Wales and Scotland are Cardiff and Edinburgh, respectively. Belfast is the capital of Northern Ireland. London is also the capital of the United Kingdom and it has a population of 8 million people. English is the official language of England, while in Wales both English and Welsh are official languages."

### Step 1 – Identify resources (subjects)
- `:UnitedKingdom`, `:England`, `:Wales`, `:Scotland`, `:NorthernIreland`
- `:London`, `:Cardiff`, `:Edinburgh`, `:Belfast`
- (Literals for population and languages)

### Step 2 – Identify predicates (use existing vocabularies where possible)
- `:comprises` (or `dcterms:hasPart`) – not standard; could invent `:comprises`
- `:hasCapital` (or `dbo:capital`)
- `:hasPopulation` (or `dbo:population`)
- `:officialLanguage` (or `dcterms:language`)

### Step 3 – Write RDF triples (Turtle)
```turtle
@prefix : <http://example.org/uk/> .
@prefix xsd: <http://www.w3.org/2001/XMLSchema#> .

:UnitedKingdom :comprises :England, :Wales, :Scotland, :NorthernIreland .

:England :hasCapital :London .
:Wales :hasCapital :Cardiff .
:Scotland :hasCapital :Edinburgh .
:NorthernIreland :hasCapital :Belfast .

:UnitedKingdom :hasCapital :London .

:London :hasPopulation "8000000"^^xsd:integer .

:England :officialLanguage "English" .
:Wales :officialLanguage "English", "Welsh" .
```

### Step 4 – Draw RDF diagram
- **Nodes** (circles/rectangles): each resource (`:UnitedKingdom`, `:England`, etc.) and literals (e.g. `"English"`).
- **Arrows** labelled with predicate names (e.g. `:comprises`, `:hasCapital`).
- For multiple objects of same predicate (e.g. `:Wales :officialLanguage "English", "Welsh"`), draw two arrows from `:Wales` to each literal, or use a blank node list (simpler: two separate triples).

**Exam tip**: In 2019 Q2, you were asked to **draw** an RDF diagram. Use clear labels and show literals as rectangles (or ovals with quotes). Ensure subject→predicate→object direction is correct.

## 2. Exercise 2: Clement Attlee RDF Diagram

**Statement**: "Clement Attlee was a British politician. He was born in London in 1883. His father was a solicitor and, after studying at Oxford University, Attlee became a barrister. He became Prime Minister when the Labour Party won the 1945 election. Attlee's government created the National Health Service."

### Step 1 – Identify resources
- `:ClementAttlee` (person)
- `:London` (place)
- `:OxfordUniversity` (organisation)
- `:LabourParty` (organisation)
- `:NationalHealthService` (organisation)
- Literals: `"British politician"` (could be a type), `"solicitor"`, `"barrister"`, `"1883"^^xsd:gYear`

### Step 2 – Suitable vocabularies (from LOV)
- `foaf:Person`, `foaf:name`, `foaf:based_near`
- `dbo:birthPlace`, `dbo:birthYear`, `dbo:primeMinister`, `dbo:party`
- `dbo:education` (Oxford University)
- `dc:creator` (Attlee's government created NHS)

### Step 3 – Example triples (Turtle with prefixes)
```turtle
@prefix foaf: <http://xmlns.com/foaf/0.1/> .
@prefix dbo: <http://dbpedia.org/ontology/> .
@prefix xsd: <http://www.w3.org/2001/XMLSchema#> .

:ClementAttlee a foaf:Person ;
               foaf:name "Clement Attlee" ;
               dbo:birthPlace :London ;
               dbo:birthYear "1883"^^xsd:gYear ;
               dbo:profession "solicitor" , "barrister" ;
               dbo:education :OxfordUniversity ;
               dbo:primeMinisterAfterElection "1945"^^xsd:gYear ;
               dbo:party :LabourParty .

:LabourParty dbo:wonElection "1945"^^xsd:gYear .

:ClementAttlee foaf:based_near :London .

:NationalHealthService dbo:creator :ClementAttlee .
```

### Step 4 – Diagram
- Main node `:ClementAttlee` with multiple outgoing edges (`a`, `foaf:name`, `dbo:birthPlace`, etc.).
- Literal nodes for `"Clement Attlee"`, `"1883"`, `"solicitor"`, etc.
- Resource nodes for `:London`, `:OxfordUniversity`, `:LabourParty`, `:NationalHealthService`.

## 3. Using LOV to Find Predicates

> The **Linked Open Vocabularies** website (`https://lov.linkeddata.es/dataset/lov`) allows you to search for existing predicates.

**Approach for exercises**:
1. For a concept like “capital of”, search for “capital” → `dbo:capital` (DBpedia ontology).
2. For “population” → `dbo:population` or `schema:population`.
3. For “official language” → `dcterms:language` or `schema:availableLanguage`.
4. For “born in” → `dbo:birthPlace`.
5. For “prime minister” → `dbo:primeMinister`.

**Exam note**: You are not expected to memorise all URIs, but you should know common prefixes (`foaf:`, `dbo:`, `dc:`, `rdfs:`) and the principle of **reusing existing vocabularies** before inventing your own.

## 4. Past Paper Traps for Lectures 15 & 16

| Statement | Answer | Reason |
|-----------|--------|--------|
| The subject in an RDF statement must be a resolvable URI | **True** | Linked Data principle |
| The predicate defines attributes of the object | **False** | Defines attributes of the **subject** |
| Fragment identifiers follow the `@` symbol | **False** | Follow the `#` hash symbol |
| Blank nodes should be used whenever possible | **False** | Avoid them; use URIs |
| `a` is shorthand for `rdf:type` | **True** | In Turtle and many serialisations |
| RDF/XML is the only RDF format | **False** | Turtle, JSON-LD, RDFa also exist |
| Anyone can create an RDF vocabulary | **True** | But reuse existing ones |
# Lecture 17 & 18: SPARQL – Querying Linked Data

## 1. What is SPARQL?

> **SPARQL** (recursive acronym for **SPARQL Protocol and RDF Query Language**) is the query language for structured data on the Web. It is the **RDF equivalent of SQL** for relational databases.

**Key capabilities**:
- Query the **Web of Data** as if it were a single, highly distributed database.
- Query **multiple data sources** at once, dynamically building a large virtual RDF graph.
- Designed to look and act as much like SQL as possible, but with important differences.

## 2. SPARQL vs SQL – Key Difference

> In SQL, `SELECT` clause names columns to retrieve from tables.  
> In SPARQL, `SELECT` clause names **variables** that were **bound in the `WHERE` clause’s triple patterns**.

**Example**:
```sparql
SELECT ?name ?url
WHERE {
  ?person rdfs:seeAlso ?url ;
          foaf:name ?name .
}
```
- `?name` and `?url` are variables that appear in the triple patterns.
- The `WHERE` clause finds all matching triples; `SELECT` decides which variables to output.

## 3. Basic SPARQL Query Structure

```sparql
PREFIX foaf: <http://xmlns.com/foaf/0.1/>
PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>

SELECT ?name ?url
WHERE {
  ?person rdfs:seeAlso ?url .
  ?person foaf:name ?name .
}
```

**Components**:
- **`PREFIX`** – declares abbreviation for a URI (same as in Turtle).
- **`SELECT`** – lists variables to return.
- **`WHERE { }`** – contains **triple patterns** (like RDF triples but with variables).
- **Variables** start with `?` (e.g. `?person`, `?name`).
- **Period (`.`)** separates triple patterns (like AND).
- **Semicolon (`;`)** allows repeating the same subject for multiple predicates (as in Turtle).

## 4. Triple Patterns and Graph Matching

> A **triple pattern** is like an RDF triple where any of subject, predicate, or object can be a variable.

The SPARQL engine finds all RDF triples in the dataset that **match** the pattern. Variables become bound to concrete URIs or literals.

**Example pattern**: `?person foaf:name ?name`
- Matches any triple with predicate `foaf:name`.
- `?person` binds to the subject (a person URI).
- `?name` binds to the object (a literal name).

## 5. Querying Multiple RDF Files (FROM clause)

> Use `FROM` to specify a particular RDF document (by URL). Multiple `FROM` clauses combine graphs from different sources.

```sparql
SELECT ?name
FROM <http://example.com/person1.rdf>
FROM <http://example.com/person2.rdf>
WHERE { ?person foaf:name ?name }
```

**Magic of Linked Data**: Reusing the **same URI** across different files allows data to be combined automatically. Two files referring to `http://example.org/people/alice` are assumed to talk about the same resource.

## 6. SPARQL Endpoints

> A **SPARQL endpoint** is a web-accessible service that accepts SPARQL queries (usually via HTTP GET or POST). It returns results in formats like JSON, XML, CSV, or HTML.

**Convention**: Many datasets expose their endpoint at `/sparql` (e.g. `http://dbpedia.org/sparql`).

**DBpedia SPARQL endpoint**: `http://dbpedia.org/sparql` – provides a web form for interactive queries.

## 7. Common SPARQL Clauses and Keywords

| Keyword | Purpose |
|---------|---------|
| `SELECT` | Choose which variables to return |
| `WHERE` | Triple patterns to match |
| `DISTINCT` | Remove duplicate results |
| `FILTER` | Restrict results based on conditions (e.g. numeric comparison, string matching) |
| `ORDER BY` | Sort results by a variable |
| `LIMIT` | Restrict number of results (not in examples but common) |
| `FROM` | Specify RDF source document(s) |

## 8. SPARQL Query Examples (from Lecture 18)

### 8.1 Find any entity with a `foaf:name`
```sparql
SELECT ?entity
WHERE {
  ?entity foaf:name ?name
}
```

### 8.2 Find any subject related to Leeds (as entity)
```sparql
PREFIX dbr: <http://dbpedia.org/resource/>
SELECT ?sub
WHERE {
  ?sub ?pred dbr:Leeds .
}
```
**Exam trap (2020 Q2w)**: "Which is a correct SPARQL query to find any subject related to Leeds?" – All of `SELECT ?sub WHERE { ?sub ?pred :Leeds. }`, `SELECT ?entity WHERE { ?entity ?pred :Leeds. }`, etc. are correct because variable names don’t matter. Answer: **D. All of the above**.

### 8.3 Find any subject related to the string "Leeds" (English language)
```sparql
SELECT ?sub
WHERE {
  ?sub ?pred "Leeds"@en .
}
```

### 8.4 Find the name of any person born in Leeds (correct pattern)
```sparql
PREFIX dbr: <http://dbpedia.org/resource/>
PREFIX foaf: <http://xmlns.com/foaf/0.1/>
PREFIX dbo: <http://dbpedia.org/ontology/>

SELECT ?name ?entity
WHERE {
  ?entity foaf:name ?name .
  ?entity dbo:birthPlace dbr:Leeds .
}
```
**Exam trap (2020 Q2x)**: The correct query must bind `?entity` as the person, then `foaf:name` gives the name, and `dbo:birthPlace` gives the place. Option B from the paper was correct.

### 8.5 Find name and spouse of any person born in Leeds
```sparql
PREFIX dbr: <http://dbpedia.org/resource/>
PREFIX foaf: <http://xmlns.com/foaf/0.1/>
PREFIX dbo: <http://dbpedia.org/ontology/>
PREFIX dbp: <http://dbpedia.org/property/>

SELECT ?name ?spouse
WHERE {
  ?entity foaf:name ?name .
  ?entity dbo:birthPlace dbr:Leeds .
  ?entity dbp:spouse ?spouse .
}
```

### 8.6 Find any person born in Leeds before 1900-01-01 (FILTER)
```sparql
PREFIX dbr: <http://dbpedia.org/resource/>
PREFIX dbo: <http://dbpedia.org/ontology/>
PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>

SELECT ?entity ?name ?birth
WHERE {
  ?entity foaf:name ?name .
  ?entity dbo:birthPlace dbr:Leeds .
  ?entity dbo:birthDate ?birth .
  FILTER (?birth < "1900-01-01"^^xsd:date)
}
```

### 8.7 People born in Berlin, ordered by name (ORDER BY)
```sparql
PREFIX dbr: <http://dbpedia.org/resource/>
PREFIX dbo: <http://dbpedia.org/ontology/>

SELECT ?person ?name
WHERE {
  ?person dbo:birthPlace dbr:Berlin .
  ?person foaf:name ?name .
}
ORDER BY ?name
```

### 8.8 Find capital of France
```sparql
PREFIX dbr: <http://dbpedia.org/resource/>
PREFIX dbo: <http://dbpedia.org/ontology/>

SELECT ?city
WHERE {
  dbr:France dbo:capital ?city .
}
```

### 8.9 Find capital cities of all countries
```sparql
PREFIX dbo: <http://dbpedia.org/ontology/>

SELECT ?country ?city
WHERE {
  ?country dbo:capital ?city .
}
```

## 9. Using `DISTINCT` and Discovering Classes

**Discover all RDF types (classes) present in a dataset**:
```sparql
SELECT DISTINCT ?Concept
WHERE {
  [] a ?Concept .
}
```
- `[]` is a **blank node** (matches any subject).
- `a` is shorthand for `rdf:type`.
- `DISTINCT` removes duplicate class names.

## 10. Important SPARQL Syntax Notes

- **Variables** begin with `?` (e.g. `?person`). Variable names can be any alphanumeric string.
- **Prefixes** must be declared before use (either in query or the endpoint may have default prefixes).
- **Literals** can have language tags (`"Leeds"@en`) or datatypes (`"1900-01-01"^^xsd:date`).
- **Semicolon** `;` allows chaining multiple predicates for the same subject (instead of repeating `?person`).
- **Comma** `,` allows multiple objects for same predicate.

**Example with semicolon** (two predicates for same subject):
```sparql
?person rdfs:seeAlso ?url ;
        foaf:name ?name .
```
Equivalent to:
```sparql
?person rdfs:seeAlso ?url .
?person foaf:name ?name .
```

## 11. Past Paper Traps for Lectures 17 & 18

| Statement | Answer | Reason |
|-----------|--------|--------|
| SPARQL is the SQL equivalent for RDF | **True** | |
| SPARQL SELECT clause names tables | **False** | It names variables from WHERE |
| `[]` in SPARQL is a blank node | **True** | |
| `a` in SPARQL is shorthand for `rdf:type` | **True** | |
| SPARQL requires `FROM` clause for every query | **False** | Without `FROM`, it queries the default graph (e.g. the endpoint's dataset) |
| A SPARQL endpoint is a web service that accepts queries | **True** | |
| Variable names are fixed (`?subject` must be used) | **False** | Any name with `?` prefix is allowed |
| `FILTER` can compare dates and numbers | **True** | |
| `ORDER BY` sorts results | **True** | |

*End of Lectures 17 & 18 notes.*