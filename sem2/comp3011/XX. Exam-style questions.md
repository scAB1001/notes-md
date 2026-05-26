# Lecture 2: HTTP – The Workhorse of the Web – Practice Exam Questions
## Section A: True or False (1 mark each)
**For each statement, write T (True) or F (False).**
### 1. HTTP stands for HyperText Transfer Protocol.
#### Model Answer
**True.** HTTP stands for **HyperText Transfer Protocol**. It is the set of rules that allows web browsers and web servers to communicate.
### 2. HTTP is a transport layer protocol.
#### Model Answer
**False.** HTTP is an **application layer** protocol, meaning it sits on top of all other network layers (including the transport layer, which is TCP).
### 3. In HTTP, requests can be initiated by either the client or the server.
#### Model Answer
**False.** Requests are **always initiated by the client**. The server only sends **responses**. This is a fundamental feature of the HTTP client-server model.
### 4. A web resource can only be a static file such as an image or text document.
#### Model Answer
**False.** A web resource can be a **static file** (the simplest kind), but it can also be a **software program** that generates content on demand (e.g. a stock trading gateway, a search engine results page, a real estate search).
### 5. Each web resource is given a unique identifier called a Uniform Resource Identifier (URI).
#### Model Answer
**True.** Every resource on the web is identified by a **URI (Uniform Resource Identifier)**. A URL is a specific type of URI that also specifies the location.
### 6. A URL is the same as a URI.
#### Model Answer
**False.** A **URL is a type of URI**, but they are not the same thing. A **URI** is the broader concept — it **identifies** a resource. A **URL** is a subset of URI that also specifies the **location** (how to access it). Every URL is a URI, but not every URI is a URL. This was tested directly in 2019 Q1i.
### 7. Anything that has a URL is a resource.
#### Model Answer
**True.** By definition, if something has a URL, it is a web resource. This was tested in 2020 Q1.5.
### 8. HTTP has evolved from HTTP/0.9 to HTTP/3, but the request–response semantics have fundamentally changed with each version.
#### Model Answer
**False.** HTTP has evolved from HTTP/0.9 to HTTP/3, improving **performance and reliability**, but the same **request–response semantics** have been **preserved** across all versions.
### 9. Each line in an HTTP message ends with a two-character sequence consisting of a carriage return and a tab character.
#### Model Answer
**False.** Each line ends with a **carriage return** followed by a **line feed** (CRLF: `\r\n`), **not** a tab character. This exact trap appeared in 2020 Q1.3.
### 10. An HTTP message consists of a start line, a block of headers, and a mandatory body.
#### Model Answer
**False.** An HTTP message consists of a **start line**, a **block of headers**, and an **optional body** (entity body). Not all messages contain entity bodies — for example, GET requests and HEAD responses have no body.
### 11. The status code in an HTTP response is a three-digit number, where the first digit describes the general class of the response.
#### Model Answer
**True.** The status code is a **three-digit number**. The **first digit** indicates the category: **1xx** = Informational, **2xx** = Successful, **3xx** = Redirection, **4xx** = Client error, **5xx** = Server error.
### 12. HTTP status code 200 means "Not Found".
#### Model Answer
**False.** Status code **200** means **"OK"** (success — requested data is in the response body). **404** is the code that means "Not Found".
### 13. Response messages to HTTP HEAD requests do not have a body.
#### Model Answer
**True.** The HEAD method behaves like GET but the server returns **only the headers** — **no entity body** is returned. This was tested directly in 2020 Q1.4.
### 14. The HEAD method can be used to determine the resource type without downloading the full resource.
#### Model Answer
**True.** HEAD returns only headers (including `Content-Type`), so you can determine the **resource type**, check if the resource **exists** (via the status code), and check if it has been **modified** (via the `Last-Modified` header) — all without downloading the body.
### 15. A GET request is used when we do not intend to change the data on a server, and therefore a GET message should not have a payload.
#### Model Answer
**True.** GET is a **safe** method (does not modify server state). While GET *technically can* have a message body, it is **recommended not to send data in it**. Data should instead be sent in a **query string**. This was tested in 2019 Q1o.
### 16. The POST method stores the body of the request at a specific URL on the server.
#### Model Answer
**False.** This describes **PUT**, not POST. **POST** sends input data to the server **for processing** (e.g. submitting a form). The **server decides** what to do with the data. **PUT** writes/stores the request body at the **specified URL**.
### 17. The DELETE method guarantees that the resource will be removed from the server.
#### Model Answer
**False.** There is **no guarantee** the delete is carried out. The HTTP specification allows the server to **override the request without telling the client**.
### 18. TRACE is a standard HTTP method.
#### Model Answer
**True.** TRACE is a **standard HTTP method** that allows clients to see how their request looks when it finally reaches the server. The server returns a TRACE response with the **original request message** in the body.
### 19. MOVE is a standard HTTP method.
#### Model Answer
**False.** MOVE is **not** a standard HTTP method. It is a **WebDAV extension method** (along with LOCK, MKCOL, and COPY). This was tested in 2020 Q2a.
### 20. MIME types were originally designed for use with HTTP.
#### Model Answer
**False.** MIME (Multipurpose Internet Mail Extensions) types were **originally designed for electronic mail**. HTTP later **adopted** them to describe multimedia content in headers.
### 21. MIME types are registered and maintained by the Internet Engineering Task Force (IETF).
#### Model Answer
**False.** MIME types are registered and maintained by **IANA (Internet Assigned Numbers Authority)**, not the IETF. The IETF *tree* is one of the four registration trees within IANA, but the overall registry authority is IANA. This was tested directly in 2020 Q1.7.
### 22. The MIME type `video/html` is a valid media type.
#### Model Answer
**False.** There is no `html` subtype under the `video` primary type. `html` belongs under the `text` primary type (i.e. `text/html`). Valid MIME types include `image/gif`, `text/plain`, and `application/vnd.ms-powerpoint`. This was tested in 2020 Q2f.
### 23. The MIME type for a Microsoft PowerPoint presentation is `application/vnd.ms-powerpoint`.
#### Model Answer
**True.** This is a **vendor tree** MIME type (indicated by the `vnd.` prefix), registered with IANA for commercially available products.
### 24. Each MIME type consists of a primary type and a subtype separated by a colon.
#### Model Answer
**False.** The primary type and subtype are separated by a **slash** (`/`), not a colon. Example: `text/html`, `image/jpeg`. Optional parameters begin with a **semicolon** (`;`).
### 25. When a client requests a resource, the server responds with a representation that always matches the server's internal representation of the resource data.
#### Model Answer
**False.** The **representation** sent to the client does **not necessarily match** the way the data is stored internally on the server. For example, data stored as a CSV file on the server could be sent to the client as JSON, HTML, or XML. This was tested in 2020 Q1.6.

---
## Section B: Multiple Choice Questions (1 mark each)

**Select the single correct answer unless otherwise stated.**
### 26. Which of the following is NOT a standard HTTP method?
- A. PUT
- B. POST
- C. MOVE
- D. TRACE
#### Model Answer
**C. MOVE.** PUT, POST, and TRACE are all standard HTTP methods. MOVE is a **WebDAV extension method**, not part of the HTTP standard. This was tested directly in 2020 Q2a.
### 27. Which HTTP method should be used in an airline API to book a flight?
- A. GET /flight
- B. PUT /flight
- C. POST /flight
- D. ADD /flight
#### Model Answer
**C. POST /flight.** Booking a flight **creates a new resource** (the booking), which is a POST operation. GET only retrieves data. PUT replaces/updates a resource at a known URL. ADD is **not a standard HTTP method** at all. This was tested in 2020 Q2i.
### 28. HTTP status codes in the range 400–499 indicate:
- A. Informational responses
- B. Successful responses
- C. Redirection
- D. Client errors
#### Model Answer
**D. Client errors.** The five status code classes are: **1xx** = Informational, **2xx** = Successful, **3xx** = Redirection, **4xx** = Client error, **5xx** = Server error.
### 29. Which of the following HTTP status codes means "Unauthorized"?
- A. 200
- B. 401
- C. 404
- D. 500
#### Model Answer
**B. 401.** 401 Unauthorized means the client needs to provide **credentials** (username and password). 200 = OK, 404 = Not Found, 500 = Internal Server Error.
### 30. Which of the following is NOT a valid MIME type?
- A. `video/html`
- B. `image/gif`
- C. `application/vnd.ms-powerpoint`
- D. `text/plain`
#### Model Answer
**A. `video/html`.** There is no `html` subtype under the `video` primary type. The correct MIME type for HTML is `text/html`. The other three are all valid registered MIME types. This was tested in 2020 Q2f.
### 31. A URL has three parts. Which of the following correctly identifies them?
- A. Protocol, Domain, Fragment
- B. Scheme, Host, Path
- C. Method, Address, Query
- D. Header, Body, Status
#### Model Answer
**B. Scheme, Host, Path.** The three parts of a URL are the **Scheme** (how — e.g. `http://`), the **Host** (where — e.g. `www.example.com`), and the **Path** (what — e.g. `/seasonal/index.html`).
### 32. Which HTTP method retrieves only the headers of a resource, without the body?
- A. GET
- B. POST
- C. HEAD
- D. OPTIONS
#### Model Answer
**C. HEAD.** HEAD behaves like GET but the server returns **only the headers** — no entity body. GET returns headers and body. POST sends data to the server. OPTIONS asks the server about supported methods.
### 33. What does the OPTIONS method do?
- A. Deletes a resource from the server
- B. Sends data to the server for processing
- C. Asks the server about what methods it supports
- D. Traces the message through proxy servers
#### Model Answer
**C. Asks the server about what methods it supports.** OPTIONS queries the server's **supported capabilities** — what methods it supports in general or for particular resources. This helps client applications determine how to access various resources.
### 34. Which of the following header types provides extra information from the client to the server, such as what data formats the client is willing to receive?
- A. General headers
- B. Request headers
- C. Response headers
- D. Entity headers
#### Model Answer
**B. Request headers.** Request headers provide extra information **to servers**, such as what data types the client will accept (e.g. `Accept: image/gif, image/jpeg, text/html`). General headers are used by both sides, response headers inform the client, and entity headers describe the body.
### 35. The MIME type `image/jpeg` describes:
- A. A plain text document
- B. A JPEG image
- C. A JavaScript file
- D. An HTML page
#### Model Answer
**B. A JPEG image.** The primary type `image` indicates an image format, and the subtype `jpeg` specifies the JPEG encoding.
### 36. MIME types are divided into four registration trees. Which of the following is NOT one of them?
- A. IETF
- B. Vendor (vnd.)
- C. Personal/Vanity (prs.)
- D. Commercial (com.)
#### Model Answer
**D. Commercial (com.).** The four MIME registration trees are: **IETF** (general significance, e.g. `text/html`), **Vendor** (`vnd.`, e.g. `application/vnd.ms-powerpoint`), **Personal/Vanity** (`prs.`, private use), and **Experimental** (`x-` or `x.`, unregistered types). There is no "Commercial" tree.
### 37. Which of the following HTTP methods has a message body? (Select two)
- A. GET
- B. POST
- C. HEAD
- D. PUT
#### Model Answer
**B and D. POST and PUT.** According to the lecture's method table, only **POST** ("Send data to the server for processing" — body: Yes) and **PUT** ("Store the body of the request on the server" — body: Yes) have message bodies. GET, HEAD, TRACE, OPTIONS, and DELETE do **not** have message bodies (or are recommended not to).
### 38. What is the difference between PUT and POST?
- A. PUT creates a resource; POST updates a resource
- B. PUT stores/replaces a resource at a known URL (idempotent); POST submits data for processing and the server decides where to store it (not idempotent)
- C. PUT sends data to a form; POST deletes a resource
- D. There is no difference; they are interchangeable
#### Model Answer
**B.** **PUT** writes/stores/replaces a resource at a **known URL** and is **idempotent** (repeating the same PUT request produces the same result). **POST** submits data for processing, and the **server decides** where/how to store it; POST is **not idempotent** (repeating it may create multiple resources).
### 39. Which of the following is a correct description of the TRACE method?
- A. It deletes a resource on the server
- B. It allows clients to see how their request looks when it finally reaches the server
- C. It creates a new resource on the server
- D. It returns the headers of a resource without the body
#### Model Answer
**B.** TRACE allows clients to see how their request looks when it finally reaches the server. The server returns a TRACE response with the **original request message** in the body. This is useful for diagnosing **proxy modifications** to the request along the way.
### 40. HTTP is field-extensible. What does this mean?
- A. HTTP messages can be of unlimited length
- B. New features and methods can be added without causing older software to fail
- C. HTTP can only be used with HTML content
- D. HTTP extensions require a new protocol version
#### Model Answer
**B.** HTTP being **field-extensible** means new features can be added (such as new methods or headers) **without causing older software to fail**. Extensions like **WebDAV** add methods such as LOCK, MKCOL, COPY, and MOVE that extend HTTP's capabilities beyond the core standard.

---
## Section C: Short Answer / Scenario-Based Questions
### 41. (3 marks) Explain the structure of an HTTP request message. Include all components and give an example of a complete request line.
#### Model Answer
An HTTP request message has three parts **(1 mark each)**:

1. **Start line (request line)**: Contains the **method** (action to perform, e.g. GET, POST), the **request-URL** (path to the resource), and the **HTTP version** (e.g. HTTP/1.1).

2. **Headers**: Zero or more headers, each formatted as `Name: value`. These provide metadata such as the host (`Host: www.example.com`), accepted content types (`Accept: text/html`), and content type of the body (`Content-Type: application/json`).

3. **Entity body (optional)**: A block of arbitrary data. Not all messages have a body — for example, GET and HEAD requests typically do not.

**Example request line**: `GET /seasonal/index-fall.html HTTP/1.1`
### 42. (3 marks) Explain the structure of an HTTP response message. What is a status code, what is a reason phrase, and give three examples of status codes with their meanings.
#### Model Answer
An HTTP response message has three parts: a **start line** (containing the HTTP version, a status code, and a reason phrase), **headers**, and an **optional body** **(1 mark)**.

A **status code** is a **three-digit number** describing what happened. The **first digit** indicates the general class (1xx informational, 2xx success, 3xx redirection, 4xx client error, 5xx server error). A **reason phrase** is a **human-readable version** of the status code **(1 mark)**.

Three examples **(1 mark)**:
- **200 OK** — Success; any requested data is in the response body.
- **401 Unauthorized** — The client needs to provide a username and password.
- **404 Not Found** — The server cannot find a resource at the requested URL.
### 43. (4 marks) Describe four different uses of the HEAD method and explain why it is useful compared to GET for each use case.
#### Model Answer
**(1 mark each, any four):**

1. **Determine resource type** — HEAD returns the `Content-Type` header, allowing the client to know the resource's MIME type (e.g. `image/jpeg`, `text/html`) **without downloading the entire body**, saving bandwidth.

2. **Check if a resource exists** — By examining the **status code** of the HEAD response (e.g. 200 = exists, 404 = not found), the client can verify existence without transferring potentially large content.

3. **Check if a resource has been modified** — The `Last-Modified` header in the HEAD response tells the client when the resource was last changed, enabling **conditional fetching** (only download if newer than the cached version).

4. **Determine resource size** — The `Content-Length` header reveals the size of the body **without downloading it**, useful for estimating download time or checking storage requirements.

In all cases, HEAD is more efficient than GET because it returns **only headers with no entity body**, reducing bandwidth and processing time.
### 44. (4 marks) Explain the difference between PUT and POST with reference to idempotency. Give a practical example of when you would use each method in a RESTful API for a bookshop.
#### Model Answer
**PUT** writes or replaces a resource at a **specific, known URL**. It is **idempotent**, meaning sending the same PUT request multiple times produces the **same server state** (the resource is simply overwritten with the same data each time) **(1 mark)**.

**POST** sends data to the server **for processing**. The server decides what to do with the data (e.g. where to store it, what resource to create). It is **not idempotent** — sending the same POST request multiple times may create **multiple new resources** **(1 mark)**.

**Bookshop example — POST**: `POST /books` with body `{"title": "New Book", "author": "Smith"}` — this **creates a new book** resource. The server assigns an ID (e.g. `/books/456`). Sending it again would create a **second** book entry **(1 mark)**.

**Bookshop example — PUT**: `PUT /books/456` with body `{"title": "Updated Title", "author": "Smith"}` — this **replaces** the book at `/books/456` with the new data. Sending it again produces the **same result** — the book at `/books/456` is still the same updated version **(1 mark)**.
### 45. (3 marks) What are MIME types? Explain their origin, structure, and give three examples of valid MIME types with their descriptions.
#### Model Answer
**MIME (Multipurpose Internet Mail Extensions)** types were **originally designed for electronic mail** to describe the type of content being sent. HTTP later adopted them to describe **multimedia content** in headers **(1 mark)**.

Each MIME type consists of a **primary type** and a **subtype** separated by a **slash** (`/`), with optional parameters beginning with a **semicolon** (`;`). Example structure: `primary-type/subtype; parameter=value` **(1 mark)**.

Three valid examples **(1 mark)**:
- **`text/html`** — an HTML-formatted text document
- **`image/jpeg`** — a JPEG image file
- **`application/vnd.ms-powerpoint`** — a Microsoft PowerPoint presentation (vendor tree MIME type)
### 46. (3 marks) MIME types are registered with a specific organisation and are divided into four registration trees. Name the organisation and describe each of the four trees with an example MIME type for each.
#### Model Answer
MIME types are registered with **IANA (Internet Assigned Numbers Authority)** **(0.5 marks)**.

The four registration trees **(0.5 marks each + 0.5 for examples)**:

1. **IETF tree** — For types of general significance to the internet community. Require approval by the Internet Engineering Steering Group. IETF tree types have **no periods** in their tokens. Example: **`text/html`**.

2. **Vendor tree (vnd.)** — For media types associated with **commercially available products**. Types begin with `vnd.`. Example: **`application/vnd.ms-powerpoint`**.

3. **Personal/Vanity tree (prs.)** — For private, personal, or vanity types **not distributed commercially**. Types begin with `prs.`. Example: **`image/prs.btif`** (internal check-management format).

4. **Experimental tree (x- or x.)** — For **unregistered or experimental** media types. Types begin with `x.` or `x-`. Example: **`application/x-tar`** (Unix tar archive).
### 47. (2 marks) A developer notices that their web crawler is receiving frequent HTTP status codes 401, 403, 404, 408, and 429. What do these status codes indicate, and what is the most likely explanation for this pattern?
#### Model Answer
These are all **client error (4xx)** status codes **(0.5 marks)**:
- **401** = Unauthorized (needs credentials)
- **403** = Forbidden (access denied)
- **404** = Not Found
- **408** = Request Timeout
- **429** = Too Many Requests

**(0.5 marks)**

The most likely explanation is that the **web crawler is being blocked** by the target server **(1 mark)**. This pattern of error codes — especially 403 (forbidden), 429 (rate limiting), and 408 (timeouts) — strongly indicates the server has detected automated crawling behaviour and is actively rejecting or throttling requests. This was tested in 2020 Q2s.
### 48. (2 marks) Explain the difference between a URI and a URL with an example.
#### Model Answer
A **URI (Uniform Resource Identifier)** is the broader concept — it **identifies** a resource, giving it a unique name **(1 mark)**. A **URL (Uniform Resource Locator)** is a **specific type of URI** that not only identifies the resource but also specifies its **location** on the network (i.e. how to access it, via scheme + host + path) **(1 mark)**.

**Example**: `http://www.example.com/page.html` is both a **URI** (it identifies the resource) and a **URL** (it tells you *where* to find it via HTTP on that host). However, an ISBN like `urn:isbn:978-0-123456-47-2` is a URI (it identifies a book) but **not** a URL (it doesn't tell you where to download it).

Every URL is a URI, but not every URI is a URL.
### 49. (3 marks) You are designing a RESTful API for a library system. Specify the HTTP method, a suitable URL, and whether the request has a message body for each of the following operations:

(a) Retrieve a list of all books
(b) Add a new book to the catalogue
(c) Delete a book with ID 42
#### Model Answer
**(1 mark each)**

**(a)** Retrieve all books:
- **Method**: `GET`
- **URL**: `/books`
- **Message body**: **No** (GET should not carry a payload; any parameters go in the query string)

**(b)** Add a new book:
- **Method**: `POST`
- **URL**: `/books`
- **Message body**: **Yes** (contains the book data, e.g. `{"title": "...", "author": "..."}`)

**(c)** Delete book 42:
- **Method**: `DELETE`
- **URL**: `/books/42`
- **Message body**: **No** (DELETE requests do not carry a body)
### 50. (2 marks) Explain the four types of HTTP headers and give one example of each.
#### Model Answer
**(0.5 marks each)**

1. **General headers** — Used by **both** clients and servers. Example: `Date: Tue, 3 Oct 1997 02:16:03 GMT` (the date the message was generated).

2. **Request headers** — Provide extra information **from client to server**, such as acceptable content types. Example: `Accept: image/gif, image/jpeg, text/html` (the client tells the server what formats it can handle).

3. **Response headers** — Provide information **from server to client**. Example: `Server: Tiki-Hut/1.0` (tells the client which server software is running).

4. **Entity headers** — Describe the **entity body** (the payload). Example: `Content-Type: text/html; charset=iso-latin-1` (tells the receiver that the body is an HTML document in ISO Latin-1 encoding).
# Lecture 3: Representational State Transfer (REST) – Practice Exam Questions

---

## Section A: True or False (1 mark each)

**For each statement, write T (True) or F (False).**

### 1. REST stands for Representational State Transitions.

#### Model Answer

**False.** REST stands for **Representational State Transfer**. "Transitions" is a common incorrect variant. This was tested in 2020 Q1.1.

### 2. REST is a protocol, not an architectural style.

#### Model Answer

**False.** REST is an **architectural style** (not a protocol). It uses **existing web protocols** such as HTTP, but does not define a new protocol of its own.

### 3. There is an official standard for RESTful Web APIs.

#### Model Answer

**False.** There is **no official standard** for RESTful Web APIs. REST implementations make use of **existing internet standards** (HTTP, URIs, JSON, XML) but the style itself has no standard. This was tested in 2019 Q1n.

### 4. The representation of data sent over the web must always match how it is stored on the server.

#### Model Answer

**False.** The **representation** sent to the client does **not necessarily match** the way the data is stored internally. Data stored as a CSV file on the server could be sent as JSON, HTML, or XML. This is the "Representational" aspect of REST and was tested in 2020 Q1.6.

### 5. Statelessness means that no client context is stored on the server between requests.

#### Model Answer

**True.** Statelessness requires that each request from client to server contains **all the information necessary** to understand the request, and the server does **not rely on any previous requests**. No client context is stored between requests.

### 6. In a stateless API, the session state must be held on the server.

#### Model Answer

**False.** In a stateless API, the **session state is held in the client**, not on the server. Each request is self-contained.

### 7. Statelessness improves reliability because if communication breaks, the process can continue later.

#### Model Answer

**True.** Statelessness improves **reliability** — the ability to recover from partial failure. If communication breaks, the process can continue later because the request contains all needed information.

### 8. Statelessness decreases network performance because repetitive data must be sent in each request.

#### Model Answer

**True.** One **disadvantage** of statelessness is that it can **decrease network performance** by increasing the amount of **repetitive data** sent in a series of requests (e.g. authentication credentials repeated every time).

### 9. Cacheable responses can be reused by the client for later equivalent requests.

#### Model Answer

**True.** Data within a response must be labelled as **cacheable or non-cacheable**. If cacheable, the client cache can **reuse** that response data for later equivalent requests, improving performance and reducing latency.

### 10. Caching improves reliability because it guarantees data is always fresh.

#### Model Answer

**False.** Caching has a **disadvantage** of reduced **reliability** if **stale data** in the cache differs from data on the server. It does not guarantee freshness.

### 11. HATEOAS stands for "Hypermedia As The Engine Of Application State".

#### Model Answer

**True.** HATEOAS is the fourth sub-constraint of the Uniform Interface. It means a representation should contain **hypermedia references (hyperlinks)** to perform further actions or access related resources.

### 12. In a truly RESTful API, a client with only the root URL can discover all other resources by following hypermedia links.

#### Model Answer

**True.** This is the **discoverability rule** (HATEOAS). The client should not need out-of-band knowledge of URL structures. Starting from the root URL, hypermedia links lead to all other resources.

### 13. The biggest challenge in RESTful web API design is finding suitable media types to represent all resources.

#### Model Answer

**False.** The biggest challenge is **bridging the semantic gap** between understanding a document's **structure** and understanding **what it means**. This was tested in 2020 Q2g.

### 14. A "fiat standard" means no one formally agreed to it; it is just a description of how someone does things.

#### Model Answer

**True.** Fiat standards are not really standards; they are **behaviours**. No one agreed to them. Pretty much every API today (Twitter API, Facebook API, Google API) is a fiat standard. This was tested in 2020 Q2e.

### 15. In the Maze+XML API, the `+xml` suffix indicates that the media type uses XML syntax but has its own defined semantics.

#### Model Answer

**True.** A **structured syntax suffix** (e.g. `+xml`, `+json`, `+zip`) is an augmentation to a media type that specifies the underlying **syntax**. `application/vnd.amundsen.maze+xml` means it uses XML syntax but has its own maze-specific semantics.

### 16. Structured syntax suffixes (like `+xml` and `+json`) are registered and maintained by IETF.

#### Model Answer

**False.** Structured syntax suffixes are registered and maintained by **IANA (Internet Assigned Numbers Authority)**. Currently registered suffixes include `+xml`, `+json`, `+zip`, `+ber`, `+der`, `+fastinfoset`, `+wbxml`, and `+cbor`.

### 17. The default priority value in a sitemap's priority tag is 0.7.

#### Model Answer

**False.** The default priority value is **0.5**. The priority range is 0.0 to 1.0, with 0.5 being the default. This was tested in 2020 Q2q.

### 18. In RESTful APIs, it is recommended to create new domain-specific media types rather than adding semantics to generic hypermedia formats.

#### Model Answer

**False.** It is **not recommended** to create new domain-specific media types. It is **less work** to add application semantics to a **generic hypermedia format** (e.g. using standard link relations). However, domain-specific design is the first instinct of many developers, leading to fiat standards.

### 19. A link relation explains the change in application state that will happen if the client triggers the control.

#### Model Answer

**True.** A **link relation** (e.g. `rel="east"`, `rel="next"`) explains the **change in application state** (for safe requests) or **resource state** (for unsafe requests) that will occur if the client follows that link.

### 20. Extension link relations look like URLs and can be defined by anyone who owns a domain.

#### Model Answer

**True.** **Extension relation types** look like URLs (e.g. `http://mydomain.com/whatever`). If you own a domain, you can name a link relation with that domain and define it to mean anything you want. **Registered relation types** are short strings like `next`, `previous`, `search`, `alternate`.

### 21. The `nofollow` link relation tells search engine crawlers not to follow the link.

#### Model Answer

**True.** `rel="nofollow"` is a registered link relation used to indicate that the linked document is **not endorsed**. Google uses it to specify that the search spider **should not follow** that link. Example: `<a rel="nofollow" href="http://www.functravel.com/">Cheap Flights</a>`.

### 22. A layered system architecture reduces scalability because each request goes through multiple layers.

#### Model Answer

**False.** A **layered system** actually **boosts scalability** because tasks (security, storage, authentication) are separated between servers without burdening the client. However, it does add **latency** because each request goes through several layers — but this is a disadvantage, not a scalability reduction.

### 23. In a layered system, the client knows exactly which servers handle each part of the request.

#### Model Answer

**False.** From the client's perspective, it connects **directly with the end server** and has **no knowledge of the intermediaries** along the way. Each layer is only aware of the **next layer**, not layers beyond it.

### 24. The Uniform Interface constraint includes resource identification, manipulation through representations, self-descriptive messages, and HATEOAS.

#### Model Answer

**True.** The Uniform Interface has **four sub-constraints**:
1. Identification of resources
2. Manipulation of resources through representations
3. Self-descriptive messages
4. HATEOAS (Hypermedia As The Engine Of Application State)

---

## Section B: Multiple Choice Questions (1 mark each)

**Select the single correct answer unless otherwise stated.**

### 25. REST was coined by Roy Fielding in his PhD thesis around which year?
- A. 1990
- B. 1995
- C. 2000
- D. 2005

#### Model Answer

**C. 2000.** REST was coined by **Roy Fielding** circa **2000** in his PhD thesis about network-based software architectures.

### 26. In RESTful APIs, statelessness means that: (Select all that apply)
- A. No client context is stored on the server between requests
- B. Each request from any client contains all the information necessary to service the request
- C. The session state is held in the client
- D. The server must remember all previous requests from a client

#### Model Answer

**A, B, and C.** Statelessness means: **no client context stored on the server** (A), **each request contains all necessary information** (B), and **session state is held in the client** (C). The server does **not** remember previous requests (D is the opposite of statelessness). This was tested in 2020 Q2h (where the correct answer was "All of the above").

### 27. Which of the following is NOT an essential part of a RESTful API working cycle?
- A. The client requests a representation of a resource
- B. The client captures the structure of the resource in a DOM tree
- C. The client decides on a new resource to be requested
- D. The client changes its current state when the new resource is received

#### Model Answer

**B. The client captures the structure of the resource in a DOM tree.** Capturing structure in a DOM tree is a **browser implementation detail**, not a REST constraint. The other three options (request representation, decide new resource, change state) are all essential parts of the REST cycle. This was tested in 2020 Q2d.

### 28. What is the biggest challenge in RESTful web API design?
- A. Finding suitable media types to represent all resources
- B. Bridging the semantic gap between understanding a document's structure and understanding what it means
- C. Avoiding identical URLs across different services
- D. Parsing the representations returned by servers

#### Model Answer

**B. Bridging the semantic gap.** A computer can easily understand a document's **structure** (e.g. discover HTML links), but it cannot understand **what each link actually does**. This gap between syntax/structure and meaning is the biggest challenge. This was tested in 2020 Q2g.

### 29. In RESTful APIs, a "fiat standard" is called as such because:
- A. No one agreed to it. It is just a description of the way somebody does things.
- B. It is widely accepted and used like the famous FIAT car brand
- C. It is set by the Free Internet Access Team (FIAT)
- D. It is set by the US Federal Government

#### Model Answer

**A. No one agreed to it. It is just a description of the way somebody does things.** Fiat standards are not really standards; they are behaviours. Pretty much every API today (Twitter API, Facebook API, Google API) is a fiat standard. This was tested in 2020 Q2e.

### 30. In the Maze+XML media type `application/vnd.amundsen.maze+xml`, what does the `+xml` suffix indicate?
- A. The media type uses XML syntax but has its own defined semantics
- B. The media type is compressed using XML
- C. The media type is only for XML files
- D. The media type requires an XML schema

#### Model Answer

**A. The media type uses XML syntax but has its own defined semantics.** A **structured syntax suffix** (e.g. `+xml`, `+json`) specifies the underlying **syntax** (structure) while allowing the media type to define its own **semantics** (meaning).

### 31. Which of the following is a registered link relation?
- A. http://mydomain.com/custom-relation
- B. east
- C. next
- D. start

#### Model Answer

**C. next.** `next` is a **registered link relation** (short string managed by IANA). `http://mydomain.com/custom-relation` is an **extension relation type** (looks like a URL). `east` and `start` are domain-specific relations defined in Maze+XML, not IANA-registered (though anyone can use them).

### 32. Which of the following is a valid IANA-registered structured syntax suffix? (Select two)
- A. +html
- B. +xml
- C. +json
- D. +rest

#### Model Answer

**B and C. +xml and +json.** Registered suffixes include: `+xml`, `+json`, `+zip`, `+ber`, `+der`, `+fastinfoset`, `+wbxml`, and `+cbor`. `+html` and `+rest` are not registered.

### 33. What is the default priority value in a sitemap's `<priority>` tag?
- A. 0.0
- B. 0.5
- C. 0.7
- D. 1.0

#### Model Answer

**B. 0.5.** The default priority of a page is **0.5**. Valid values range from 0.0 to 1.0. Priority is relative within a site — assigning high priority to all pages does not help. This was tested in 2020 Q2q.

### 34. Which of the following is an advantage of statelessness?
- A. Decreases network performance
- B. Reduces server control over application behaviour
- C. Improves reliability (recovery from partial failure)
- D. Requires sending repetitive data

#### Model Answer

**C. Improves reliability (recovery from partial failure).** Advantages of statelessness include: improved **reliability** (recovery from partial failure), improved **visibility** (a monitor only needs one request), and **simplified implementation** (server doesn't remember previous requests). Disadvantages include decreased network performance (A), reduced server control (B), and repetitive data (D).

### 35. In the Maze+XML API, how does a client know where to start exploring the maze?
- A. There is a `rel="entrance"` link relation
- B. The root URL returns a collection with `rel="maze"` links, and each maze has a `rel="start"` link
- C. The client must guess the start cell URL
- D. The first cell is always `/cells/A`

#### Model Answer

**B. The root URL returns a collection with `rel="maze"` links, and each maze has a `rel="start"` link.** The Maze+XML standard defines: collection (`rel="maze"`) → individual maze (`rel="start"`) → start cell. This demonstrates **discoverability** (HATEOAS).

### 36. What does `rel="nofollow"` tell search engine crawlers?
- A. The link is the most important on the page
- B. The crawler should not follow the link (the linked document is not endorsed)
- C. The link points to the next document in a series
- D. The link points to a help document

#### Model Answer

**B. The crawler should not follow the link (the linked document is not endorsed).** `rel="nofollow"` is used for paid links or unendorsed content. Google's crawler respects this directive.

### 37. Which of the following is a valid registered HTML link relation for providing a link to the author of a document?
- A. `rel="author"`
- B. `rel="creator"`
- C. `rel="writer"`
- D. `rel="owner"`

#### Model Answer

**A. `rel="author"`.** `author` is a registered HTML link relation that provides a link to the **author of the document**. Other common registered relations include `alternate`, `bookmark`, `external`, `help`, `license`, `next`, `prev`, `search`, and `tag`.

### 38. Which of the following statements about blank nodes in RDF is true?
- A. Blank nodes should be used whenever possible
- B. Blank nodes are resources that have a URI
- C. Blank nodes are anonymous resources without a URI and should be avoided when possible
- D. Blank nodes cannot be used in RDF diagrams

#### Model Answer

**C. Blank nodes are anonymous resources without a URI and should be avoided when possible.** Blank nodes (`_:nodeID` or `[]`) are used when you need to describe a resource that doesn't have a URI. However, they cannot be referenced from outside the document, make data merging difficult, and should be **avoided whenever possible**.

### 39. In a layered system architecture, which statement is true?
- A. The client knows all intermediate servers
- B. Each layer is aware of all other layers
- C. From the client's perspective, it connects directly with the end server
- D. Layered systems cannot use caching

#### Model Answer

**C. From the client's perspective, it connects directly with the end server.** The client has **no knowledge of the intermediaries** along the way. Each layer is only aware of the **next layer**. This is one of the five REST constraints.

### 40. What is the purpose of the `rel="alternate"` link relation?
- A. Provides a link to an alternate representation of the document (e.g. print page, translated version)
- B. Provides a link to the next document in a series
- C. Provides a link to a search tool for the document
- D. Provides a link to copyright information

#### Model Answer

**A. Provides a link to an alternate representation of the document (e.g. print page, translated version).** `alternate` is a registered link relation. Examples: a print-friendly version, a translated page, or an RSS feed version of the current page.

---

## Section C: Short Answer / Scenario-Based Questions

### 41. (4 marks) List and briefly explain the five REST constraints.

#### Model Answer

**(1 mark each, any five — the lecture covers five constraints; some lists include Code-on-Demand as optional sixth):**

1. **Client-Server** — Separation of concerns between user interface (client) and data storage (server). Improves portability and allows independent evolution.

2. **Statelessness** — Each request contains all necessary information; no client context is stored on the server between requests. Session state is held in the client.

3. **Cacheability** — Responses must be labelled as cacheable or non-cacheable. Cacheable responses can be reused for later equivalent requests, improving performance.

4. **Uniform Interface** — Standardised methods (HTTP verbs), resource identification via URIs, manipulation through representations, self-descriptive messages, and HATEOAS.

5. **Layered System** — Client cannot tell if it is connected directly to the end server or an intermediary. Each layer is only aware of the next layer.

**(Optional sixth constraint: Code-on-Demand — server can extend client functionality by sending executable code, e.g. JavaScript.)**

### 42. (3 marks) Explain HATEOAS. Why is it important for a truly RESTful API?

#### Model Answer

**HATEOAS (Hypermedia As The Engine Of Application State)** is the fourth sub-constraint of the Uniform Interface **(1 mark)**.

It requires that a representation returned from the server should contain **hypermedia references (hyperlinks)** to perform further actions or access related resources **(1 mark)**.

**Importance for truly RESTful APIs**: With HATEOAS, a client starting with **only the root URL** can discover **all other resources** by following hypermedia links. The client does **not need out-of-band knowledge** of URL structures (e.g. `/users/123` is not hardcoded; it is discovered via a link). This enables **loose coupling** — the server can change URL structures without breaking clients, as long as link relations remain consistent **(1 mark)**.

### 43. (3 marks) Explain the semantic gap in RESTful API design and how the Maze+XML API attempts to bridge it.

#### Model Answer

The **semantic gap** is the difference between understanding a document's **structure/syntax** (e.g. HTML tags, XML elements) and understanding its **meaning** in the application domain **(1 mark)**. A computer can easily parse a link `<a href="/pay">` but doesn't know that following it will **transfer money**.

The **Maze+XML API** bridges the gap by **(2 marks, any two)**:
1. **Defining application-specific link relations** (`rel="east"`, `rel="west"`, `rel="start"`, `rel="exit"`) with documented meanings that client developers can program into their clients.
2. **Registering a media type** (`application/vnd.amundsen.maze+xml`) with IANA, associating it with a **human-readable specification** that explains the semantics.
3. **Providing a collection at the root URL** with `rel="maze"` links, enabling clients to discover mazes without hardcoded URLs.

### 44. (4 marks) Compare and contrast registered link relations and extension link relations. Give two examples of each.

#### Model Answer

**(2 marks for definitions, 2 marks for examples)**

**Registered link relations** are short strings (e.g. `next`, `previous`, `search`, `alternate`) that are **managed by IANA**. There are currently about 60 registered relations deemed generally useful and not tied to a particular data format **(1 mark)**.

**Extension link relations** look like **URLs** (e.g. `http://mydomain.com/custom`). Anyone who owns a domain can define an extension relation to mean anything they want. No formal registration is required **(1 mark)**.

**Examples of registered relations (1 mark for two correct examples)**:
- `next` — link to the next document in a series
- `prev` — link to the previous document in a series
- `alternate` — link to an alternate representation (e.g. print page)
- `search` — link to a search tool for the document
- `nofollow` — indicates the linked document is not endorsed

**Examples of extension relations (1 mark for two correct examples)**:
- `http://example.com/vocab#east` (Maze+XML's `rel="east"` is actually a short string in that API, but extension relations look like URLs)
- `http://schema.org/author` (schema.org relations are often used as extension relations)
- Any custom URL like `http://mycompany.com/rels/archive`

### 45. (3 marks) Describe the Maze+XML collection pattern. How does it enable discoverability?

#### Model Answer

The Maze+XML **collection pattern** uses a hierarchical structure to enable clients to discover mazes starting from only the root URL **(1 mark)**.

**Root URL response** (collection of mazes):
```xml
<maze version="1.0">
  <collection>
    <link rel="maze" title="A Beginner's Maze" href="/beginner"/>
    <link rel="maze" title="For Experts Only" href="/expert-maze/start"/>
  </collection>
</maze>
```

**GET `/beginner`** returns an individual maze representation:
```xml
<maze version="1.0">
  <item>
    <title>A Beginner's Maze</title>
    <link rel="start" href="/cells/C"/>
  </item>
</maze>
```

**How this enables discoverability (2 marks)**:
- The client only needs to know the **root URL** and the **semantics of the link relations** (`rel="maze"`, `rel="start"`).
- Following `rel="maze"` leads to a maze; following `rel="start"` leads to the start cell.
- No hardcoded URL patterns (`/beginner` or `/cells/C`) are required in the client.
- The server can change these URLs without breaking clients, as long as the link relations remain the same.

### 46. (2 marks) What are structured syntax suffixes? Name three registered suffixes.

#### Model Answer

**Structured syntax suffixes** are augmentations to a media type that specify the underlying **structure (syntax)** of that media type **(1 mark)**. For example, `application/vnd.amundsen.maze+xml` means the media type uses XML syntax but has its own defined semantics.

**Three registered suffixes (1 mark for any three)**: `+xml`, `+json`, `+zip`, `+ber`, `+der`, `+fastinfoset`, `+wbxml`, `+cbor`.

### 47. (3 marks) Explain the trade-off in statelessness: improved reliability vs decreased network performance.

#### Model Answer

**Improved reliability (1.5 marks)**: Statelessness means each request contains **all necessary information** and does not rely on previous requests. If communication breaks, the process can **continue later** because the next request is self-contained. This also makes it easier to **recover from partial failure** (e.g., if a server crashes, any other server can handle the next request). Monitoring is also easier because a single request shows the complete context.

**Decreased network performance (1.5 marks)**: Because each request must be **self-contained**, repetitive data (e.g. authentication credentials, user context) must be sent in **every request** rather than being remembered by the server. This increases the amount of data transmitted, which can be particularly costly for chatty APIs (many small requests). For example, a client making 100 API calls must send its authentication token 100 times instead of once.

### 48. (2 marks) Explain the difference between safe and idempotent HTTP methods in the context of REST. Give one example of a safe method and one example of a non-safe but idempotent method.

#### Model Answer

**Safe methods** do **not modify server state**. They are read-only operations. Example: **GET** **(1 mark)**.

**Idempotent methods** produce the **same server state** when the same request is sent multiple times. Sending a request once has the same effect as sending it twice or more. Example: **PUT** (replacing a resource with the same data multiple times leaves the resource unchanged) — PUT is **not safe** (it modifies state) but is **idempotent** **(1 mark)**.

**Comparison**: DELETE is idempotent (deleting the same resource twice has the same effect as deleting it once — after the first delete, the resource is gone). POST is neither safe nor idempotent (sending the same POST twice may create two resources).

### 49. (3 marks) A company is designing a new RESTful API. They propose putting all resource identifiers in query parameters (e.g. `GET /getUser?id=123`). Identify two violations of REST constraints and explain how to fix them.

#### Model Answer

**Violation 1 — Uniform Interface (Resource Identification)** (1.5 marks): REST requires that resources be identified by **unique and stable identifiers** in the **URL path**, not by query parameters. `GET /getUser?id=123` uses a verb in the URL (`getUser`) and a query parameter for the ID.

**Fix**: Use `/users/123` — the noun (resource type) in the path, the identifier in the path, no verbs.

**Violation 2 — Uniform Interface (Manipulation through Representations)** (1.5 marks): The URL `GET /getUser` implies an RPC-style operation ("get me a user") rather than retrieving a representation of a resource.

**Fix**: Use HTTP methods correctly — `GET /users/123` retrieves a representation. To update, use `PUT /users/123` with the updated representation in the body. To delete, use `DELETE /users/123`. To create a new user, use `POST /users`.

### 50. (2 marks) What is a rank sink in PageRank? How does the "surprise me" button (teleportation) solve the rank sink problem?

#### Model Answer

A **rank sink** is a page (or set of pages) with **no outgoing links** (dead end) or a page that forms a **loop** that traps the random surfer **(1 mark)**. In the basic PageRank formula, once the surfer reaches a rank sink, they cannot leave, and probability accumulates there incorrectly.

The **"surprise me" button (teleportation)** solves this by introducing a probability `λ` (typically 0.15) that at each step, instead of following a link, the surfer **jumps to a random page** anywhere on the web **(1 mark)**. This guarantees that the surfer can eventually reach every page, eliminating the sink problem. The PageRank formula becomes `PR(u) = λ/N + (1-λ) × Σ PR(v)/L(v)`.

---

# Lecture 4: Bridging the Semantic Gap – Practice Exam Questions

---

## Section A: True or False (1 mark each)

**For each statement, write T (True) or F (False).**

### 1. In the REST cycle, steps 1–5 (request, receive, parse, change state, recognise controls) are easy to implement in autonomous code.

#### Model Answer

**True.** Steps 1–5 (requesting a resource, receiving a representation, parsing it, changing state, and recognising hypermedia controls) can be easily implemented in fully autonomous code. The difficult step is **step 6 — deciding which new resource to request**.

### 2. A computer program can easily understand both the structure and the meaning of a document's hyperlinks.

#### Model Answer

**False.** A computer can easily understand a document's **structure** (e.g. discover HTML links), but it cannot understand **what each link actually does** (the meaning). This is the semantic gap.

### 3. The semantic gap is the difference between understanding a document's syntax and understanding its meaning in the application domain.

#### Model Answer

**True.** The **semantic gap** is the difference between understanding the **structure/syntax** of a document (e.g. HTML tags, XML elements) and understanding its **meaning** in the application domain.

### 4. We can completely eliminate the semantic gap with good API design.

#### Model Answer

**False.** There is **no magic shortcut**. The semantic gap **cannot be eliminated completely** because computers are not as smart as humans. However, we can **narrow the gap** with good API design.

### 5. To bridge the semantic gap from server to client, the API designer should write a human-readable specification and register IANA media types.

#### Model Answer

**True.** The API designer should: (1) write down application semantics in a **human-readable specification**, and (2) **register one or more IANA media types** for the design, associating the media types with the human-readable specification.

### 6. To bridge the semantic gap from client to server, the client developer should look up unknown media types in the IANA registry and read the human-readable specification.

#### Model Answer

**True.** The client developer: (1) looks up an **unknown media type in the IANA registry**, and (2) **reads the human-readable specification** to learn how to deal with documents of that media type.

### 7. A human-driven client (e.g. a mobile app where a human makes decisions) still faces the full semantic gap problem.

#### Model Answer

**False.** With a **human in the loop**, the semantic gap is **not a problem** because the human understands the meaning. The human makes decisions about where to navigate; the computer just follows instructions.

### 8. In HTML, the `rel` attribute (link relation) can only be used on `<a>` elements.

#### Model Answer

**False.** The `rel` attribute can be added to **both `<a>` and `<link>` elements**. This was tested in 2020 Q2c.

### 9. A client that has been programmed with the Maze+XML specification can explore a maze without any human intervention.

#### Model Answer

**True.** An **automated client** (like the "Mapmaker") can explore a maze automatically if it has been programmed with the semantics of `rel="east"`, `rel="west"`, `rel="start"`, and `rel="exit"`.

### 10. Failure to set a value to the Accept HTTP header field is a feature of a badly designed robot.

#### Model Answer

**False.** Failure to set the `Accept` header is **not** necessarily a feature of a badly designed robot (it's poor practice but not a sign of malicious behaviour). Bad robot features include: quick requests to the same site, failure to read robots.txt, and making requests at a regular monotonous rate. This was tested in 2020 Q2k.

### 11. A badly designed robot makes requests to the same website at a regular and monotonous rate, making it easy to detect.

#### Model Answer

**True.** Crawlers that make requests at a **regular and monotonous rate** can be easily detected. Sophisticated bots **randomize the timing** of page requests to avoid detection.

### 12. A server can detect a crawler by checking if it downloads the robots.txt file.

#### Model Answer

**False.** Downloading `robots.txt` is **normal behaviour** for well-behaved crawlers. Detection methods include quick successive requests, monotonous rates, trap links, and fictitious resources.

### 13. Trap links are hidden links that human users cannot see but naive robots will follow.

#### Model Answer

**True.** A **trap link** (e.g. `/trap_unwanted_robots`) can be hidden using CSS (e.g. `display:none`). Human users do not see or click it, but naive robots will follow it, revealing their identity.

### 14. Fictitious resources (e.g. `/followme/1/1`, `/followme/1/2`, ...) can cause naive robots to enter infinite recursion.

#### Model Answer

**True.** Dynamically created links to a sequence of fictitious resources that **never terminates** will cause naive robots to go into **infinite recursion**, destabilising the robot. Crawlers can avoid this by having a **limit on maximum depth**.

### 15. Robots can avoid trap links by reading the robots.txt file, which often points to these trap links.

#### Model Answer

**True.** The `robots.txt` file usually points to robot trap links. A well-behaved robot reads `robots.txt` and will **avoid** those disallowed paths.

### 16. The User-Agent HTTP header can be spoofed (faked) by crawlers to avoid detection.

#### Model Answer

**True.** The `User-Agent` header can be used to declare the identity of a crawler or browser. However, any client can **fake its identity** (spoofing). Servers cannot rely solely on User-Agent for detection.

### 17. CAPTCHA pages are a sign that your robot is being blocked.

#### Model Answer

**True.** CAPTCHA pages, unusual content delivery delays, and frequent HTTP status codes (401, 403, 404, 408, 429) are all indications that a robot is **being blocked**. This was tested in 2020 Q2s.

### 18. The `Crawl-delay` directive in robots.txt is a standard part of the robots.txt specification.

#### Model Answer

**False.** `Crawl-delay` is a **non-standard extension**. The robots.txt standard includes `User-agent`, `Allow`, and `Disallow`. `Crawl-delay` is supported by many crawlers but is not part of the official specification.

---

## Section B: Multiple Choice Questions (1 mark each)

**Select the single correct answer unless otherwise stated.**

### 19. In the REST cycle, which step is the most difficult to implement in fully autonomous code?
- A. Requesting a representation of a resource
- B. Parsing the representation
- C. Changing the client's current state using information from the representation
- D. Deciding which new resource to request

#### Model Answer

**D. Deciding which new resource to request.** Steps 1–5 are easy to automate. Step 6 — deciding which new resource to request — is difficult because it requires understanding the **meaning** of the available options, not just their syntax.

### 20. Which of the following is NOT an indication that a web crawler is being blocked? (Select the exception)
- A. CAPTCHA pages
- B. Frequent 404 Not Found responses
- C. Very short content delivery delays
- D. Frequent 429 Too Many Requests responses

#### Model Answer

**C. Very short content delivery delays.** Indications of blocking include: CAPTCHA pages, **unusual content delivery delay** (very long delays, not short), and frequent HTTP status codes (401, 403, 404, 408, 429). Very short delays would indicate normal or fast service, not blocking.

### 21. Which of the following is a feature of a badly designed robot? (Select three)
- A. Quick page requests to the same website
- B. Failure to download and read the robots.txt file
- C. Setting a value to the Accept HTTP header field
- D. Making requests to the same website at a regular and monotonous rate

#### Model Answer

**A, B, and D.** Bad robot features include: **quick requests to the same site** (A), **failure to read robots.txt** (B), and **monotonous request rate** (D). Setting the `Accept` header (C) is good practice, not a bad feature. This was tested in 2020 Q2k.

### 22. What is the purpose of the `Accept` HTTP header?
- A. To tell the server what content types the client can handle
- B. To authenticate the client
- C. To specify the client's user agent name
- D. To request only the headers of a resource

#### Model Answer

**A. To tell the server what content types the client can handle.** The `Accept` header (e.g. `Accept: image/gif, image/jpeg, text/html`) informs the server which media types the client is willing to receive. Failure to set this is poor practice but not a sign of a badly designed robot.

### 23. Which of the following can cause a naive crawler to enter infinite recursion?
- A. robots.txt with `Disallow: /`
- B. Fictitious resources that never terminate (e.g. `/page/1`, `/page/2`, ...)
- C. HTTP 200 OK responses
- D. A single page with no outgoing links

#### Model Answer

**B. Fictitious resources that never terminate.** A sequence of dynamically generated links (e.g. `/followme/1/1`, `/followme/1/2`, `/followme/1/3`, ...) that never ends will cause a naive crawler to follow links forever. Mitigation: set a **maximum depth limit**.

### 24. How can a crawler avoid being trapped by fictitious resources?
- A. Never follow any links
- B. Set a limit on the maximum number of levels it can go deep down the same page hierarchy
- C. Ignore all links with numeric parameters
- D. Only crawl pages that end in `.html`

#### Model Answer

**B. Set a limit on the maximum number of levels it can go deep down the same page hierarchy.** By setting a **depth limit**, the crawler will stop following links after reaching a certain number of levels, preventing infinite recursion.

### 25. A web server administrator wants to block a specific badly behaved crawler called "BadCrawler" but allow all other crawlers. Which robots.txt directive accomplishes this?
- A. `User-agent: * Disallow: /`
- B. `User-agent: BadCrawler Disallow: /`
- C. `User-agent: BadCrawler Allow: /`
- D. `Crawl-delay: 0`

#### Model Answer

**B. `User-agent: BadCrawler Disallow: /`.** This blocks all paths (`Disallow: /`) for the specific user agent "BadCrawler". The `*` user agent (all other crawlers) would have no restrictions (assuming no other blocks).

---

## Section C: Short Answer / Scenario-Based Questions

### 26. (3 marks) Explain the REST cycle and identify which step is the most challenging for autonomous clients.

#### Model Answer

The REST cycle for a software agent **(1 mark for listing steps)**:
1. Client requests a representation of a resource
2. Server sends the representation in some format (e.g. HTML, JSON)
3. Client parses the representation
4. Client changes its current state using information from the representation
5. Client recognises control structures (e.g. `<a>` tags, hypermedia links)
6. Client decides on a new resource to request → back to step 1

**Most challenging step (2 marks)**: **Step 6 — deciding which new resource to request**. While steps 1–5 can be easily automated (parsing, state changes, link recognition), step 6 requires understanding **what each link means**. A computer can see a link `<a href="/pay">Click here to pay</a>` but does not know that following it will transfer money. This is the **semantic gap**.

### 27. (3 marks) Describe three ways a web server can detect and block unwanted web crawlers.

#### Model Answer

**(1 mark each, any three):**

1. **Quick successive requests** — The most obvious feature of a badly designed robot is making very quick page requests to the same website. Well-behaved crawlers respect politeness policies (e.g. waiting several seconds between requests).

2. **Trap links** — A hidden link (e.g. using CSS `display:none`) that human users cannot see (and thus will not click). When a naive robot follows this link, the server detects it and can block the crawler. Robots can avoid this by reading `robots.txt`, which usually points to these trap links.

3. **Monotonous request rate** — Crawlers that make requests to the same website at a regular, predictable rate (e.g. exactly every 5 seconds) are easily detected. Sophisticated bots randomise the timing of requests.

4. **Fictitious resources** — A dynamically created sequence of links that never terminates (e.g. `/page/1`, `/page/2`, `/page/3`, ...). Naive robots enter infinite recursion. Mitigation: set a maximum depth limit.

5. **User-Agent blacklisting** — The `User-Agent` HTTP header identifies the crawler. Unwanted bots can be blacklisted. However, crawlers can spoof (fake) their User-Agent to avoid detection.

### 28. (3 marks) What are trap links and fictitious resources? How can a well-designed crawler avoid each?

#### Model Answer

**Trap links (1.5 marks)**: Hidden links (e.g. CSS `display:none`, small font, same colour as background) that **human users cannot see or click**, but naive crawlers will follow because they parse all links regardless of visibility. **Avoidance**: Read the `robots.txt` file, which typically points to these trap links with `Disallow` directives. Do not crawl disallowed paths.

**Fictitious resources (1.5 marks)**: A dynamically generated sequence of links that **never terminates** (e.g. `/followme/1/1`, `/followme/1/2`, `/followme/1/3`, ...). Each page contains a link to the next page in the sequence, creating an infinite chain. **Avoidance**: Set a **maximum depth limit** (e.g. stop after following 10 levels of the same page hierarchy). Once the depth limit is reached, the crawler stops following further links from that branch.

### 29. (2 marks) What HTTP status codes indicate that a web crawler is likely being blocked? Name at least four.

#### Model Answer

**(0.5 marks for status code group explanation, 1.5 marks for four codes):**

Frequent appearance of these status codes is an indication of blocking **(0.5 marks)**:

- **401 Unauthorized** — Credentials required
- **403 Forbidden** — Access denied
- **404 Not Found** — Resource not found (may be a trap)
- **408 Request Timeout** — Server timed out waiting for request
- **429 Too Many Requests** — Rate limiting (crawling too fast)
- **503 Service Unavailable** — Server overloaded (possibly due to crawler)

**(Any four correct status codes = 1.5 marks)** This was tested in 2020 Q2s.

### 30. (2 marks) A web server administrator wants to block a crawler that identifies itself as "BadBot" but allow all other crawlers. Write the appropriate robots.txt directives.

#### Model Answer

```txt
User-agent: BadBot
Disallow: /

User-agent: *
Disallow:
```

**(1 mark for correct structure with two user-agent blocks)**

- The first block (**User-agent: BadBot**) with **Disallow: /** blocks the specific crawler from accessing **any** resources on the site.
- The second block (**User-agent: ***) with **Disallow:** (empty) allows all other crawlers to access everything (since an empty Disallow means allow all).
- Alternatively, omitting the second block would mean no restrictions for other crawlers (default is allow), but explicit is clearer.

**(1 mark for correct explanation of what each directive does)**

---

# Lecture 5: The Hypermedia Zoo – Practice Exam Questions

---

## Section A: True or False (1 mark each)

**For each statement, write T (True) or F (False).**

### 1. Plain text (`text/plain`) has no structure except what is dictated by natural language rules.

#### Model Answer

**True.** Plain text has **no structure or format** except what is dictated by the rules of the natural language used (e.g. English vocabulary and grammar). It is best for very short API responses targeted at humans.

### 2. HTML is the best choice for representing pure data intended for machine-to-machine communication.

#### Model Answer

**False.** HTML is designed to describe **human-readable documents**. It is **not the best choice for representing pure data** for machine-to-machine communication (such as database records or spreadsheet values). XML and JSON are better suited for this purpose.

### 3. HTML5.2 was the last numbered version of HTML; HTML is now a living standard.

#### Model Answer

**True.** **HTML5.2** was the last numbered version of HTML. Currently, HTML is a **living standard** — continuously updated without version numbers.

### 4. CSS (Cascading Style Sheets) dictates how HTML documents are rendered by the client.

#### Model Answer

**True.** Without CSS, it is up to the client (browser) to decide how to render the document (e.g. what font size or colour to use). **CSS** provides control over rendering.

### 5. XML tags are predefined with specific meanings, just like HTML tags.

#### Model Answer

**False.** The XML standard only imposes restrictions on the **syntax** of the document and **does not assign any semantics to the tags**. Anyone can invent their own XML-based data format and define the semantics separately. HTML tags, by contrast, are predefined (e.g. `<h1>` means heading, `<p>` means paragraph).

### 6. XML is mainly used for machine-to-human communication, while HTML is mainly used for machine-to-machine communication.

#### Model Answer

**False.** **HTML** is mainly used for **machine-to-human** communication (web pages for people). **XML** is mainly used for **machine-to-machine** communication (data exchange). SOAP chose XML for this reason.

### 7. XML is platform independent and can be read and understood by humans as well as machines.

#### Model Answer

**True.** Being text-based, XML is **platform independent** (shared by other text-based formats) and is **readable and understandable by humans as well as machines**.

### 8. JSON supports comments, making it self-documenting.

#### Model Answer

**False.** JSON does **not** have the capability to add comments. This is a notable disadvantage compared to formats like YAML, which supports `#` comments. Workarounds (e.g. using a `"_comment"` field) are non-standard.

### 9. JSON is built on two universal data structures: a collection of name-value pairs and an ordered list of values.

#### Model Answer

**True.** JSON is built on two structures that are supported by **all programming languages**:
1. A collection of **name-value pairs** (object, record, dict, hash table)
2. An **ordered list of values** (array, vector, list, sequence)

### 10. JSON has higher overhead (more metadata) than XML, making it heavier for data transmission.

#### Model Answer

**False.** JSON provides a **low overhead alternative to XML**. XML contains a lot of metadata (e.g. tag delimiters, opening and closing tags), making it heavier. JSON is more compact.

### 11. RSS and Atom are both XML-based syndication formats for website updates.

#### Model Answer

**True.** **RSS (Really Simple Syndication)** and **Atom** are both XML-based formats that allow client applications to access updates to websites in a machine-readable format. Atom is an alternative to RSS, often considered more robust.

### 12. The MIME type for RSS is `application/rss+xml`; for Atom it is `application/atom+xml`.

#### Model Answer

**True.** RSS uses `application/rss+xml`. Atom uses `application/atom+xml`. Both use the `+xml` structured syntax suffix.

### 13. SOAP uses JSON as its underlying data format.

#### Model Answer

**False.** SOAP uses **XML** as its underlying data format. When web services such as SOAP were developed, XML was the natural choice for data exchange. The SOAP media type is `application/soap+xml`.

### 14. YAML uses indentation to define structure, and tabs are allowed for indentation.

#### Model Answer

**False.** YAML uses **indentation** (spaces) to define structure, but **tabs are not allowed**. Only spaces are permitted for indentation.

### 15. JSON is a language-independent data format despite its name "JavaScript Object Notation".

#### Model Answer

**True.** Despite the name, JSON is **language-independent**. It is supported by libraries in virtually all programming languages, not just JavaScript.

### 16. Creating a new XML-based media type should be your first choice when designing an API.

#### Model Answer

**False.** Creating a new domain-specific media type should be a **last resort** in order to avoid creating yet another **fiat standard**. It is less work to add application semantics to a **generic hypermedia format** (e.g. using standard link relations).

### 17. HTML can embed other data formats such as XML.

#### Model Answer

**True.** HTML can embed other data formats. For example, XML can be embedded within HTML (e.g. inside `<script>` tags or as data attributes).

### 18. The MIME type `application/xml` is used for XML documents that are primarily machine-readable.

#### Model Answer

**True.** `application/xml` (or `text/xml`) is the MIME type for XML. Unlike HTML (`text/html`), XML is primarily for machine-to-machine communication, not human consumption.

---

## Section B: Multiple Choice Questions (1 mark each)

**Select the single correct answer unless otherwise stated.**

### 19. Which of the following is NOT a valid structured syntax suffix registered with IANA?
- A. +xml
- B. +json
- C. +yaml
- D. +zip

#### Model Answer

**C. +yaml.** Registered structured syntax suffixes include `+xml`, `+json`, `+zip`, `+ber`, `+der`, `+fastinfoset`, `+wbxml`, and `+cbor`. `+yaml` is not currently a registered suffix.

### 20. Which media type is best suited for very short API responses targeted at humans (e.g. "OK" or "Service unavailable")?
- A. `application/json`
- B. `text/plain`
- C. `text/html`
- D. `application/xml`

#### Model Answer

**B. `text/plain`.** Plain text has no structure and is best for **very short API responses targeted at humans**. JSON and XML would add unnecessary structure and overhead.

### 21. Which of the following is NOT a valid MIME type for an XML-based format?
- A. `application/rss+xml`
- B. `application/atom+xml`
- C. `application/soap+xml`
- D. `application/html+xml`

#### Model Answer

**D. `application/html+xml`.** HTML is not typically served with `+xml` suffix. Valid XML-based MIME types include RSS (`application/rss+xml`), Atom (`application/atom+xml`), SOAP (`application/soap+xml`), and Maze+XML (`application/vnd.amundsen.maze+xml`).

### 22. What is the primary purpose of XML?
- A. Rendering web pages in browsers
- B. Data storage and serialisation, regardless of how it is rendered
- C. Adding styling to HTML documents
- D. Creating interactive web applications

#### Model Answer

**B. Data storage and serialisation, regardless of how it is rendered.** Unlike HTML (which represents the structure of human-readable documents), XML is used to represent **pure data** independent of rendering. Main purpose is data storage and serialisation.

### 23. Which of the following is an advantage of JSON over XML?
- A. Supports comments
- B. Requires more bandwidth (higher overhead)
- C. Easy to parse and lower overhead
- D. Has built-in semantics

#### Model Answer

**C. Easy to parse and lower overhead.** JSON advantages include: low overhead (reduces storage and bandwidth), easy to parse (native in JavaScript, libraries in all languages), and ability to represent almost all kinds of data. JSON does **not** support comments (A) and has **no** built-in semantics (D). JSON has **lower** overhead than XML (B is false).

### 24. Which of the following is a disadvantage of JSON compared to YAML?
- A. JSON is more verbose
- B. JSON does not support comments
- C. JSON cannot represent nested data
- D. JSON is not human-readable

#### Model Answer

**B. JSON does not support comments.** YAML supports comments starting with `#`. JSON has no comment capability. Both can represent nested data (C is false), both are human-readable (D is false), and JSON is actually less verbose than XML but YAML is often even less verbose than JSON (A is debatable but not the primary disadvantage).

### 25. Which YAML feature makes it particularly suitable for configuration files?
- A. It is a binary format
- B. It supports comments (`#`) and is highly human-readable
- C. It requires no indentation
- D. It has built-in encryption

#### Model Answer

**B. It supports comments (`#`) and is highly human-readable.** YAML's comment support and human-friendly syntax (indentation-based structure, fewer brackets than JSON) make it popular for configuration files (e.g. Docker Compose, CI/CD pipelines).

### 26. What is the MIME type for JSON?
- A. `text/json`
- B. `application/json`
- C. `application/javascript`
- D. `json/application`

#### Model Answer

**B. `application/json`.** The official MIME type for JSON is `application/json`. Not `text/json` (though sometimes used historically) or `application/javascript` (that's for JavaScript code).

### 27. Which of the following statements about RSS and Atom is true?
- A. RSS is more robust than Atom
- B. Atom is an alternative to RSS with better support for metadata
- C. Both use JSON as the underlying syntax
- D. RSS is the only syndication format that supports images

#### Model Answer

**B. Atom is an alternative to RSS with better support for metadata.** Atom is often considered more robust and has better metadata support (author, updated time). Both use **XML** as underlying syntax (C is false). RSS does support images (D is false).

### 28. Which of the following is a valid MIME type for a custom XML-based media type you have invented?
- A. `application/myapp+xml`
- B. `myapp/xml`
- C. `text/xml-myapp`
- D. `application/x-myapp+xml`

#### Model Answer

**D. `application/x-myapp+xml` (or D) – but careful:** The standard pattern for experimental/unregistered types is `application/x-<name>+xml` or `application/vnd.<company>.<name>+xml` for vendor types. The lecture recommends using existing formats when possible, but if you must create one, use the `vnd.` vendor tree or `x-` experimental prefix. `application/myapp+xml` (A) is not a standard pattern (no vendor or experimental prefix). The safest answer among these is not perfect, but in exam terms, `application/vnd.myapp+xml` would be correct. However, given the options, **A** is closer if we assume the exam treats "custom" as unregistered — but the lecture explicitly says "use as last resort" and register with IANA. For exam purposes, remember: **vendor tree = `vnd.` prefix**.

*(Note: The lecture states: "If none of the existing XML-based media types meet your needs, you can create your media type and even try to register it with IANA. Use this as a last resort." The proper pattern is `application/vnd.companyname.format+xml`.)*

### 29. Which format uses indentation (spaces, not tabs) to define structure and supports comments?
- A. JSON
- B. XML
- C. YAML
- D. CSV

#### Model Answer

**C. YAML.** YAML (YAML Ain't Markup Language) uses **indentation** (spaces only, no tabs) to define structure and supports **comments** starting with `#`. JSON does not support comments. XML uses tags, not indentation. CSV is tabular.

### 30. What is the MIME type for SOAP messages?
- A. `application/soap+xml`
- B. `text/soap`
- C. `application/xml-soap`
- D. `soap/xml`

#### Model Answer

**A. `application/soap+xml`.** The SOAP media type is `application/soap+xml`. SOAP uses XML as its underlying syntax, hence the `+xml` suffix.

---

## Section C: Short Answer / Scenario-Based Questions

### 31. (4 marks) Compare and contrast HTML and XML. Include their purposes, tag semantics, and typical use cases (human vs machine communication).

#### Model Answer

**(2 marks for similarities, 2 marks for differences):**

**Similarities (1 mark for two similarities)**:
- Both are textual markup languages
- Both use tags (angle brackets) to delimit elements
- Both are platform-independent and human-readable
- Both can be parsed by standard libraries

**Differences (3 marks):**

| Aspect | HTML | XML |
|--------|------|-----|
| **Purpose** | Describes structure of human-readable documents | Represents pure data for storage and serialisation |
| **Tag semantics** | Tags are **predefined** with specific meanings (`<h1>` = heading, `<p>` = paragraph) | Tags can be **anything**; no predefined semantics |
| **Communication** | Mainly **machine-to-human** (web pages for people) | Mainly **machine-to-machine** (data exchange) |
| **Rendering** | Browsers render based on tags | No default rendering (data only) |
| **Verbosity** | Can be verbose (lots of metadata) | Even more verbose (requires closing tags, quotes) |

### 32. (3 marks) List three advantages and two disadvantages of JSON compared to XML.

#### Model Answer

**Advantages (1.5 marks for any three)**:
1. **Lower overhead** — JSON is more compact than XML, reducing storage and bandwidth requirements.
2. **Easy to parse** — JSON maps directly to native data structures in JavaScript and has libraries in all languages.
3. **Human-readable** — Cleaner syntax with fewer angle brackets and closing tags.
4. **Faster parsing** — Generally faster to parse than XML due to simpler grammar.

**Disadvantages (1.5 marks for any two)**:
1. **No comments** — JSON does not support comments, making it harder to self-document.
2. **No built-in schema** — JSON has no built-in validation (though JSON Schema exists as a separate standard).
3. **No namespaces** — JSON lacks XML's namespace support, making integration of multiple vocabularies harder.
4. **Less expressive for certain data structures** — XML handles mixed content (text with inline elements) more naturally.

### 33. (2 marks) What is the difference between RSS and Atom? Which one is more robust for metadata?

#### Model Answer

**RSS (Really Simple Syndication)** and **Atom** are both **XML-based syndication formats** for website updates **(1 mark)**.

**Atom** is generally considered more robust, particularly for **metadata**. Atom provides built-in support for:
- Author information (`<author>`)
- Publication and update dates (`<published>`, `<updated>`)
- Unique identifiers (`<id>`)
- Multiple alternate representations (`<link rel="alternate">`)

RSS has multiple incompatible versions (0.91, 0.92, 2.0), while Atom is a single, well-defined IETF standard. **Atom is the better choice for applications requiring rich metadata (1 mark).**

### 34. (3 marks) You are designing an API that needs to return a list of items. The server can return JSON, XML, or Collection+JSON. Which format(s) are acceptable in a RESTful API, and why?

#### Model Answer

**All of the above are acceptable (1 mark).**

REST does **not mandate a specific media type**. The Uniform Interface constraint requires that the client and server agree on the media type, but the choice is flexible. This was tested in 2020 Q2j (answer: "Any of the above") **(1 mark)**.

- **JSON** (`application/json`) — Most common choice today; lightweight, easy to parse, supported everywhere.
- **XML** (`application/xml`) — Acceptable, especially in legacy systems or SOAP-based services; more verbose.
- **Collection+JSON** (`application/vnd.collection+json`) — A specialised hypermedia format designed specifically for lists/collections; provides built-in support for pagination, queries, and templates.

**Best practice recommendation (1 mark)**: JSON is recommended for most modern REST APIs due to its low overhead and ease of client-side parsing. However, providing **content negotiation** (clients specify `Accept: application/json` or `Accept: application/xml`) allows the server to support multiple formats.

### 35. (2 marks) Explain why creating a new domain-specific XML media type should be a last resort in API design. What should you do instead?

#### Model Answer

Creating a new domain-specific media type should be a **last resort** because it results in a **fiat standard** — a one-off design that no one else has agreed to **(1 mark)**. This creates more work for client developers, reduces interoperability, and fails to benefit from existing standards and tools.

**What to do instead (1 mark)**:
- **Reuse existing generic hypermedia formats** (e.g. JSON, XML, Collection+JSON) and add application semantics using **standard link relations** (e.g. `rel="next"`, `rel="prev"`, `rel="search"`) registered with IANA.
- If custom semantics are needed, use **extension link relations** (URLs) rather than inventing a whole new media type.
- Only create a new media type when the semantics cannot be expressed with existing formats and link relations.

### 36. (2 marks) Name three XML-based data formats discussed in the lecture and their MIME types.

#### Model Answer

**(2/3 mark each for correct name and MIME type — any three):**

1. **RSS (Really Simple Syndication)** — `application/rss+xml`
2. **Atom (Atom Syndication Format)** — `application/atom+xml`
3. **SOAP (Simple Object Access Protocol)** — `application/soap+xml`
4. **Maze+XML** — `application/vnd.amundsen.maze+xml`
5. **Sitemap** — `application/xml` (or often `text/xml` for sitemap.xml)

### 37. (3 marks) Explain what a "fiat standard" is in the context of RESTful APIs. Why are most commercial APIs (e.g. Twitter API, Facebook API) considered fiat standards?

#### Model Answer

A **fiat standard** is not really a standard; it is a **description of the way somebody does things**. No one formally agreed to it. It may be documented, but it lacks the core assumption of a standard — that other people ought to do things the same way **(1 mark)**.

Most commercial APIs are considered fiat standards because they are **one-off designs associated with a specific company**. The "Twitter API" works for Twitter's specific business requirements, but it is not a general standard that other companies have agreed to follow **(1 mark)**.

**Why this happens (1 mark)**: Under ideal circumstances, a fiat standard would be just a light gloss over a number of other standards (e.g. using standard HTTP methods, standard link relations, and standard media types). However, many developers create domain-specific designs as their first instinct, inventing new media types and custom link relations instead of reusing existing standards. This results in a fiat standard with limited interoperability.

### 38. (2 marks) Write a YAML representation of the following JSON object: `{"person": {"name": "Alice", "age": 30, "hobbies": ["reading", "hiking"]}}`

#### Model Answer

```yaml
person:
  name: Alice
  age: 30
  hobbies:
    - reading
    - hiking
```

**(1 mark for correct indentation structure; 1 mark for correct conversion of JSON to YAML syntax — no quotes around keys, spaces after colons, dashes for list items.)**

Note: YAML also supports comments; adding e.g. `# user profile` is optional but shows awareness of YAML's comment feature.

### 39. (2 marks) What is a "living standard" for HTML? Why did the W3C move to this model?

#### Model Answer

A **living standard** means the specification is **continuously updated** rather than released in numbered versions (e.g. HTML5.2 was the last numbered version) **(1 mark)**.

**Reason for the move**: The web evolves rapidly. A living standard allows the specification to keep pace with **browser implementations** and new web platform features without waiting for a new numbered version to be finalised. It is maintained by the **WHATWG** (Web Hypertext Application Technology Working Group) rather than W3C for HTML. This model supports **iterative development** and faster deployment of new features **(1 mark)**.

### 40. (2 marks) What is the difference between `application/xml` and `text/xml`? When would you use each?

#### Model Answer

Both are MIME types for XML, but they imply different handling by clients **(1 mark)**:

- **`application/xml`** — The XML document is treated as **generic application data** regardless of content. Clients should not attempt to render it as human-readable text. Preferred for machine-to-machine communication.

- **`text/xml`** — The XML document is treated as **text** (like `text/plain` or `text/html`). Clients may attempt to display it as human-readable. Historically, some clients handle `text/xml` differently (e.g., displaying it in a browser window).

**When to use each (1 mark)**:
- Use **`application/xml`** for machine-to-machine communication (web services, data exchange).
- Use **`text/xml`** when the XML is intended to be read by humans (e.g., debugging output, documentation examples). However, many developers simply use `application/xml` for all XML to avoid ambiguity.

*End of Lectures 3, 4, and 5 Practice Exam Questions.*