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
```
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
```
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

**Exam trap (2020 Q2a)**: "Which of the following is NOT a standard HTTP method? A. PUT, B. POST, C. MOVE, D. TRACE" — **C. MOVE** is not a standard HTTP method. It is a **WebDAV extension method**.

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

**Exam trap (2020 Q2h)**: "In RESTful APIs, statelessness means that: A. No client context is stored on the server between requests. B. Each request contains all the information necessary to service the request. C. The session state is held in the client. D. **All of the above.**" — Answer is **D. All of the above**.

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

**4.4.1 Identification of Resources** — Each resource must be identified by a **unique and stable identifier**:

- **Unique**: each identifier points to one and only one resource
- **Stable**: should not be altered later on
- **Persistent**: remains valid as long as the resource exists
- **Opaque**: clients don't need to understand what the ID means

**Good REST identifiers**: `/users/123`, `/blog/2025/02/03/rest-tutorial`, `/invoices/INV-2024-0003` **Bad REST identifiers**: `/getUser/getUserData/fetchOrder` (verbs in URL), `/user?id=123` (query string as identifier), `/users/current` (unstable — changes depending on who's logged in)

**4.4.2 Manipulation of Resources Through Representations** — The client does **not directly manipulate** the resource itself. Instead, it works with a **representation** of that resource, and the server uses that representation to update the real thing. The representation contains **all the information** needed to process the request.

**4.4.3 Self-Descriptive Messages** — Messages should carry **all the information** that the receiving party needs to process the message successfully. For example, the **media type** of the message body should be stated (e.g. `Content-Type: application/json`) so the receiver knows how to interpret the payload.

**4.4.4 HATEOAS (Hypermedia As The Engine Of Application State)** — A representation returned from the server should contain **hypermedia references (hyperlinks)** to perform further actions or access related resources. This is sometimes called the **discoverability rule**.

**Example**: If an e-commerce client requests a shopping cart's contents, the server should also send hyperlinks for **checkout**, **payment**, and other related actions — not just the cart data.

**Exam trap (2020 Q2d)**: "Which of the following is NOT an essential part of a RESTful API working cycle? A. Client requests a representation of a resource. B. **Client captures the structure of the resource in a DOM tree.** C. Client decides on a new resource to be requested. D. Client changes its current state when the new resource is received." — Answer is **B**. Capturing structure in a DOM tree is not a REST constraint; it's a browser implementation detail.

### 4.5 Layered System

> A **layered architecture** allows the API implementation to reside on one server but source data from a **separate database server**, or perform authentication from yet another server.

From the client's perspective, it connects **directly with the end server** and has **no knowledge of the intermediaries** along the way. Each layer is only aware of the **next layer**, not layers beyond it.

**Advantage**: Boosts **scalability** as tasks (security, storage, authentication) are separated between servers without burdening the client. **Disadvantage**: Adds **latency** because each request needs to go through several layers.

## 5. The Semantic Gap (Exam-Critical)

**Exam trap (2020 Q2g)**: "The biggest challenge in RESTful web API design is: A. Finding suitable media types to represent all the resources. B. **Bridging the semantic gap between understanding a document's structure and understanding what it means.** C. Avoiding identical URLs. D. Parsing representations." — Answer is **B**. The semantic gap is about the difference between understanding a document's structure (e.g. HTML tags) and understanding what the data actually _means_.

## 6. Fiat Standards

**Exam trap (2020 Q2e)**: "In RESTful APIs, a 'fiat standard' is called as such because: A. **No one agreed to it. It is just a description of the way somebody does things.** B. It is widely accepted like FIAT cars. C. Set by FIAT team. D. Set by the US government." — Answer is **A**. A fiat standard is one that is simply a description of how someone does things, without formal agreement or standardisation body approval.

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
