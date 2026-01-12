# Lecture 1: Introduction to Data Science

## 1. Core Definition & Scope

> **Data Science** is a multidisciplinary field using principles, algorithms, and processes to extract **nonobvious and useful patterns** from **large data sets**. It encompasses the full **data lifecycle**: capture, cleaning, analysis, modelling, and presentation.

*   **Machine Learning (ML)** is a subset focused on algorithmic pattern extraction.
*   **Data Mining** typically analyses structured data for discovery.
*   **Data Science** includes **unstructured data** (e.g., social media), **big-data technologies**, and **data ethics**.
## **2. Datafication**

> **Datafication** is the process of taking all aspects of life and turning them into **quantifiable data**. Once datafied, information can be repurposed into new forms of value.

**Example**: A **fitness tracker** datafies sleep, movement, and heart rate. The resulting data allows a user to derive **actionable insights**, such as linking poor sleep quality to late-night screen time, which would be difficult to notice otherwise.
## **3. Key Skills of a Data Scientist**
*   **Technical**: Computer Science, Mathematics, Statistics, Machine Learning.
*   **Domain Expertise**: Understanding the specific field (e.g., healthcare, film).
*   **Soft Skills**: Communication, Presentation, **Data Visualisation**.
## **4. Core Process & Workflow**
1.  **Data Collection & Preparation**: **Collecting, Curating, Cleaning**. The most time-consuming phase.
2.  **Analysis & Modelling**: **Visualize, Analyze, Model (Machine Learning)**.
3.  **Critical Questions Before Modelling**:
    *   Does the **past represent the future**? (Assumption for predictive models).
    *   What is the **goal** of the model?
    *   How will it be **used**?
    *   What data is **needed** vs. **available**?
## **5. Example Applications**
*   **IMDb**: Structured, crowdsourced data enabling questions on actor careers, film success factors (**correlation** between budget/ratings), and societal trends (e.g., age disparity between actors/actresses).
*   **Gapminder**: Uses **GDP per capita** (a **metric** for national wealth) to analyse relationships with health outcomes like life expectancy, demonstrating **exploratory data analysis**.
## **6. Historical Context & Greater Data Science (GDS)**
*   **50-Year Foundation**: Roots in statistics (Tukey, Cleveland) advocating for a broader **data analysis** science beyond theory.
*   **Lesser Data Science (LDS)**: Current, narrow commercial focus on **big-data** tools and scalability.
*   **Greater Data Science (GDS)**: Donoho's proposed rigorous framework with six divisions:
    1.  Data Exploration & Preparation.
    2.  Data Representation & Transformation.
    3.  Computing with Data.
    4.  Data Modelling (includes both **statistical inference** and **predictive modelling**).
    5.  Data Visualisation & Presentation.
    6.  **Science about Data Science**: Empirical study of data analysis methods themselves.
*   **Common Task Framework (CTF)**: Key driver of ML progress; uses public **benchmarks**, shared data, and objective scoring to compare algorithms.
## **7. Core Objectives & Values**
*   **Primary Goal**: Derive **actionable insights**, not just numbers. Requires asking the **right questions**.
*   **Statistical Reasoning Values**: Understanding the **application domain**, appreciating the **small** (details matter), quest for **significance**, hunger for **exploration**.
*   **Future Direction**: Evolution towards **evidence-based methodology** via **Science about Data Science**, using meta-analysis of computational research to improve methods.
# Lecture 2: Data Understanding & Profiling

## 2.1 What is Data?

> A **datum** is a single measurement of something on a scale understandable to both recorder and reader. **Data** are multiple such measurements.

**Objective Example**: Using the **Titanic dataset** (891 rows, 12 columns) to predict passenger survival based on personal characteristics (age, ticket class, gender). This is a **classification** task.

## 2.2 Data Sources
*   **Internal Sources**: Data already collected within an organization (e.g., business operations data, experimental data).
*   **Existing External Sources**: Ready-to-use data from outside (e.g., government databases, stock market feeds, Yelp reviews). Accessed via **APIs** (often paid), **RSS feeds**, or downloads.
*   **External Sources Requiring Collection**: Data requiring extraction effort (e.g., printed data, website data). **Web scraping** (extracting data from HTML) is a common method.

## 2.3 Web Scraping Considerations
*   **Why**: Lack of API, cost avoidance, data availability.
*   **Ethical/Legal Concerns**: Violating **Terms of Service**, privacy issues, bypassing paid services. Essential to consider before publishing analysis or products.

## 2.4 Key Data Properties
*   **Structure**: The "shape" of a data file (e.g., tabular, **non-rectangular**). Tabular data is standard, with rows as records and columns as fields/variables.
*   **Granularity**: The level of detail (e.g., individual people vs. aggregated groups).
*   **Scope**: How complete the data is relative to the research question. **Poor scope** leads to inability to answer the question or need for filtering.
*   **Temporality**: How data is situated in time. Considerations: collection date, **periodicity** (e.g., diurnal patterns), and the meaning of time fields (event time vs. entry time).
*   **Faithfulness**: How well data captures reality. Check for: unrealistic values (future dates, negative counts), violated dependencies (age vs. birthday), data entry errors, default values, duplication, and timezone inconsistencies.

## 2.5 Data Types & Values
**Atomic Types**: Numeric (integers, floats), Boolean, Strings.
**Compound Types**:
*   **Date/Time**: Structured temporal data.
*   **Lists**: Sequences of values.
*   **Dictionaries**: Collections of **key-value pairs** (e.g., `{"First": "Kevin", "Last": "Rader", "Classes": ["CS-109A", "STAT139"]}`).

## 2.6 Handling Missing Data
*   **Deletion**: Dropping records with missing values. Risk: introduces **bias** if missingness is not random.
*   **Keep as NaN**: Represent missingness explicitly.
*   **Imputation**: Inferring missing values.
    *   **Average Imputation**: Replace with mean/median (often within a subgroup).
    *   **Hot Deck Imputation**: Replace with a random value from similar records.
    *   **Regression Imputation**: Replace with a value predicted by a model.
    *   **Multiple Imputation**: Create multiple datasets with different imputed values to account for uncertainty.
    *   **Essential**: Understand **why data is missing** (Missing Completely at Random - MCAR, Missing at Random - MAR, Missing Not at Random - MNAR).

## 2.7 Data Storage Formats
*   **Tabular Data**: Two-dimensional tables (rows=records, columns=variables). Formats: CSV, Excel.
*   **Structured Data**: Records as dictionaries with consistent keys. Formats: JSON, XML.
*   **Semi-structured Data**: Records lack uniform structure; some data not in key-value pairs.

## 2.8 Common Issues & Data Cleaning
**Generic Profiling Questions**: Dataset size, completeness, representativeness, presence of outliers/artificial data, uniqueness of identifiers.
**Joining Data**: Use **primary keys** (unique column(s) identifying a record) and **foreign keys** (columns referencing a primary key in another table). `pd.merge` in Pandas performs joins.
**Messy Data Symptoms**: Column headers are values, variables in rows/columns, multiple variables in one column, multiple entity types in one table.
**Tidy Data Principle**: Each file is a dataset, each column a single **variable**, each row a single **observation**.

## 2.9 Hierarchy of Data Categories
![[data-types.png|400]]
*   **Quantitative** (intervals have meaning):
    *   **Continuous**: Measurable to arbitrary precision (e.g., Price, Temperature).
    *   **Discrete**: Finite, countable values (e.g., Number of siblings).
*   **Qualitative (Categorical)**:
    *   **Ordinal**: Categories with ordered levels, but differences not consistent (e.g., Education level, Shirt size (S,M,L), Yelp star rating).
    *   **Nominal**: Categories with no inherent order (e.g., Political affiliation, Race/Ethnicity).
**Complex Examples**: GPA (treated as continuous), Income bracket (ordinal), CO2 level (continuous).

## 2.10 Practical Guide to Data Profiling
**Goal**: Move from *ad-hoc* to **rigorous, reproducible** data investigation, which consumes 50-90% of project time.
**Six-Step Workflow**:
1.  **Look at your data** (initial sanity check).
2.  **Watch out for special values** (codes for missing data).
3.  **Check for missing data** (coverage, duplicates).
4.  **Check each variable** individually (format, distribution, plausibility).
5.  **Check combinations of variables** (correlations, business rules).
6.  **Characterise the cleaned data** (final profiling).
**Core Aspects**:
*   **Data Characterisation**: Understanding what the data *is* (structure, distributions).
*   **Data Quality Investigation**: Assessing **fitness for purpose** via:
    *   **Completeness** (missing data).
    *   **Accuracy** (incorrect/implausible values).
    *   **Consistency** (format, units across sources).
**Tool**: Python package `vizdataquality` to automate profiling tasks in Jupyter.