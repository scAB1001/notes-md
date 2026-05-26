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