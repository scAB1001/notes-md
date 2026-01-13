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
# Lecture 3: Data Science Roadmap & Exploratory Data Analysis (EDA)

## 3.1 Data Science Roadmap
1.  **Frame Problem**: Define the objective and scope (e.g., predict Titanic survival).
2.  **Understand Data**: Perform **data profiling** and **cleaning**.
3.  **Extract Features**: Engineer or select relevant variables.
4.  **Model and Analyse**: Apply **machine learning** algorithms.
5.  **Present/Deploy**: Communicate results and deploy solution.

## 3.2 Exploratory Data Analysis (EDA)
> **EDA** is an attitude of flexibility aimed at discovering both expected and unexpected patterns in data. It is the "unboxing" of data.

**Goal**: Develop hypotheses, understand data structure, and inform modelling choices using **visualisations** and **summary statistics**.

**Example Context**: Titanic dataset (891 passengers, 12 features) for survival prediction.

## 3.3 Key Python Libraries for EDA
*   **Matplotlib**: Core plotting library. Powerful but has non-intuitive syntax.
*   **Pandas**: Data manipulation. Provides high-level plotting wrappers around matplotlib.
*   **NumPy**: Foundation for numerical computation (arrays, matrices).
*   **Scikit-learn**: Machine learning library (algorithms, utilities, built-in datasets like **Iris**).

## 3.4 Iris Dataset Example
A built-in dataset for **classification** (predicting iris species).
```python
from sklearn.datasets import load_iris
iris = load_iris()
X = iris.data  # Feature matrix (150 samples, 4 features)
y = iris.target  # Target vector (species: 0=setosa, 1=versicolor, 2=virginica)
```
**Key Steps**: Load data, inspect `shape`, `feature_names`, `target_names`, convert to Pandas DataFrame, use `.describe()` for summary statistics (mean, std, min, max, percentiles).

## 3.5 Summary Statistics & Central Tendency
*   **Central Tendency**: `mean` (average), `median` (middle value), `mode` (most frequent).
*   **Variability**: `variance` (average squared deviation from mean), `standard deviation` (sqrt of variance), `quantiles` (e.g., 25th percentile = Q1, 75th percentile = Q3).
*   **Robust Statistics**: Median and **interquartile range (IQR = Q3 - Q1)** are less sensitive to **outliers** than mean and standard deviation.
*   **Outlier Handling**: Can filter using percentiles (e.g., remove data outside IQR) but context is critical (e.g., fraud detection requires keeping outliers).

## 3.6 Key Visualisation Techniques

### Pie Chart
*   **Use Case**: Showing proportion of a whole for a **categorical variable**.
*   **Data Type**: **Nominal** or **Ordinal**.
*   **Example**: Breakdown of Iris species counts in the dataset.
*   **Code**: `df.groupby('species').sum().plot(kind='pie')`

### Bar Chart
*   **Use Case**: Comparing quantities across **discrete categories**.
*   **Data Type**: **Categorical** (Nominal/Ordinal) on one axis, **quantitative** on the other.
*   **Example**: Average sepal width per Iris species.
*   **Code**: `df.groupby('species').mean().plot(kind='bar')`

### Histogram
*   **Use Case**: Visualising the **distribution** of a single **continuous variable**.
*   **Data Type**: **Quantitative** (Continuous or Discrete).
*   **Example**: Distribution of petal lengths across all flowers.
*   **Code**: `df['petal length (cm)'].plot(kind='hist')`

### Box Plot
*   **Use Case**: Summarising distribution and identifying **outliers**. Shows median, IQR (box), and whiskers (typically 1.5*IQR).
*   **Data Type**: **Quantitative**.
*   **Example**: Comparing sepal length distributions across species.
*   **Code**: `df.pivot('ind', 'species')['sepal length (cm)'].plot(kind='box')`

### Scatter Plot
*   **Use Case**: Visualising relationship between **two continuous variables**.
*   **Data Type**: **Quantitative** vs. **Quantitative**.
*   **Enhancements**: Use `color`, `size`, `marker`, `alpha` (transparency) to encode additional dimensions (e.g., species).
*   **Example**: Sepal length vs. sepal width, colored by species.
*   **Code**: `df.plot(kind='scatter', x='sepal length (cm)', y='sepal width (cm)')`

### Scatter Plot with Logarithmic Axes
*   **Use Case**: Data spanning **orders of magnitude**. Reveals patterns obscured on a linear scale.
*   **Data Type**: **Positive quantitative** data with wide range.
*   **Example**: Crime rate vs. median home value (inverse relationship becomes clear on log scale).
*   **Method**: Plot `log(data)` or set `ax.set_xscale('log')`.

### Scatter Matrix (Pairs Plot)
*   **Use Case**: Simultaneously visualising pairwise relationships between **multiple numeric features**.
*   **Data Type**: **Quantitative**.
*   **Output**: Grid of scatterplots and histograms.
*   **Example**: Quick assessment of all feature relationships in the Iris dataset.

### Heatmap
*   **Use Case**: Visualising **density** or **intensity** in a 2D space, especially useful for large datasets where scatterplots become cluttered.
*   **Data Type**: **Quantitative** density derived from two quantitative variables.
*   **Example**: Density of data points in petal length vs. petal width space.

### Time Series Plot
*   **Use Case**: Analysing data points indexed in **time order** to identify trends, cycles, and anomalies.
*   **Data Type**: **Quantitative** values over **time**.
*   **Considerations**: Periodicity, overall trend, noise, spikes.
*   **Transformations**: Log scale, **Fourier transform** for frequency analysis.
*   **Example**: Atmospheric CO2 levels over years, showing yearly cycles and upward trend.

## 3.7 Profiling Studies & Best Practices
*   **Core Insight**: Profiling is often **ad-hoc and superficial**. A **structured workflow** (e.g., the 6-step guide) improves rigour.
*   **Six-Step Workflow**: 1) Initial look, 2) Find special values, 3) Check missing data, 4) Inspect individual variables, 5) Check variable relationships, 6) Final characterisation.
*   **Data Quality Dimensions**: Assess **Completeness** (missingness), **Accuracy** (valid, plausible values), **Consistency** (formats, units).
*   **Visualisation for Profiling**: Underutilised for quality checks. Should be used more comprehensively.
*   **Tool Support**: Python packages like `vizdataquality` can automate and formalise the profiling process.
# Lecture 4: Machine Learning Overview

## 4.1 Core Definitions & Relationships

> **Data Mining (Knowledge Discovery in Data - KDD)** is the process of uncovering patterns and valuable information from large datasets.

> **Artificial Intelligence (AI)** is the broader field of creating systems that perform tasks requiring human-like intelligence (e.g., learning, reasoning). It has two main approaches:
> *   **Top-down (Knowledge-driven)**: Starts with symbolic rules and logic (e.g., Expert Systems).
> *   **Bottom-up (Data-driven)**: Starts from data to build decision mechanisms mathematically (e.g., Machine Learning).

> **Machine Learning (ML)** is a subset of AI focused on programming computers to **optimise a performance criterion using example data or past experience**. It combines **Statistics** (inference from a sample) and **Computer Science** (efficient algorithms for optimisation and model evaluation).

## 4.2 When to Use Machine Learning
Use ML when:
1.  **Human expertise does not exist** (e.g., navigating on Mars).
2.  **Humans cannot explain their expertise** (e.g., speech recognition).
3.  **The solution changes over time** (e.g., network routing).
4.  **The solution needs personalisation** (e.g., user biometrics).

**Core Principle**: Learning **general models** from **specific example data**. Data is abundant; knowledge (models) is valuable.

## 4.3 Data Mining vs. Machine Learning
*   **Data Mining**: Discovers **existing patterns** in data (descriptive).
*   **Machine Learning**: **Learns from past data** to build models for **predicting future outcomes** (predictive). ML is a primary tool used within the KDD process.

## 4.4 Supervised Learning
**Situation**: When you have a dataset of **input/output pairs (labeled data)** and want to predict an output for new inputs.
**Goal**: Learn a **mapping function** from inputs to outputs.
**Training**: Model learns from a **training set** of example pairs.

### Classification
**Situation**: The output is a **categorical label** (class) from a predefined list.
*   **Binary Classification**: Two possible classes (e.g., spam/not spam, low-risk/high-risk credit).
*   **Multiclass Classification**: More than two classes (e.g., language of a website, digit recognition).
**Example**: Credit scoring. **Inputs**: Income, savings. **Output**: "low-risk" or "high-risk". A **discriminant** function (e.g., `IF income > θ1 AND savings > θ2`) can be learned.

### Regression
**Situation**: The output is a **continuous quantitative value**.
**Goal**: Predict a number.
**Example**: Predicting the steering angle for a self-driving car (**Robot Arm Kinematics**), forecasting house prices, estimating patient recovery time.

![[supervised-unsupervised-tree 1.png]]

## 4.5 Unsupervised Learning
**Situation**: When you have **input data without corresponding labels** (unlabeled data). The goal is to find inherent structure or patterns.
**No supervision**: The algorithm is only given input data.

### Dimensionality Reduction
**Situation**: You have high-dimensional data (many features) and want a **lower-dimensional representation** that preserves essential information. Used for **visualisation** (reducing to 2D/3D), noise reduction, or data compression.
**Primary Method**: **Principal Component Analysis (PCA)**.
**Example**: Visualising a multi-feature dataset (like Iris) in 2D to see if natural groupings exist.

### Clustering
**Situation**: You want to **partition data into distinct groups** where points in the same group are similar and points in different groups are dissimilar.
**Goal**: Discover inherent groupings.
**Examples**:
*   **Customer Segmentation (CRM)**: Group customers by purchasing behavior.
*   **Image Compression**: **Color quantization** by grouping similar pixel colors.
*   **Biology**: Grouping genes with similar expression patterns.

![[cluster-ex.png]]

## 4.6 Reinforcement Learning
**Situation**: An **agent learns to make decisions by performing actions in an environment to maximise cumulative reward**. It receives **delayed feedback** (reward or penalty), not direct supervision.
**Key Challenge**: **Credit Assignment Problem** – determining which actions led to the received rewards.
**Examples**: Game playing (AlphaGo), robot navigation in a maze, autonomous driving systems.
# Lecture 5: Clustering & Similarity

## 5.1 Data Similarity & Distance Metrics
**Situation**: When you need to quantify how alike (or different) two data points are. This is foundational for **clustering**, **recommendation systems**, and **nearest-neighbor algorithms**.
**Core Idea**: Objects represented as **feature vectors**. Similarity is inversely related to **distance** in the feature space.

### Euclidean Distance
**Situation**: The most common distance metric, used when data is **continuous** and features are on **comparable scales**. It measures the "straight-line" distance.
**Formula**: For points $p = (p_1, p_2, ..., p_n)$ and $q = (q_1, q_2, ..., q_n)$:
$$
d(p, q) = \sqrt{(p_1 - q_1)^2 + (p_2 - q_2)^2 + ... + (p_n - q_n)^2}
$$
**Example**: Measuring distance between two customers based on their (scaled) annual spending and age.
![[euclidian-dist.png]]

## 5.2 k-Means Clustering
**Situation**: When you need to partition data into a **predefined number (k)** of **spherical or convex clusters** of roughly equal size. It is **scalable** to large datasets.

### Algorithm Steps:
1.  **Initialization**: Randomly select **k** data points as initial **cluster centers** (centroids).
2.  **Assignment Step**: Assign each data point to the **closest centroid** (using Euclidean distance).
3.  **Update Step**: Recompute each centroid as the **mean** of all points assigned to it.
4.  **Iteration**: Repeat steps 2 & 3 until **convergence** (assignments no longer change).

![[k-means-cluster-ex.png]]

**Python Implementation**:
```python
from sklearn.cluster import KMeans
kmeans = KMeans(n_clusters=3)
kmeans.fit(X)
labels = kmeans.labels_          # Cluster assignments for training data
new_labels = kmeans.predict(X_new) # Assign new points to clusters
```

### Evaluation & Loss Functions
*   **Inertia (Within-Cluster Sum of Squares)**: Sum of squared distances of each point to its assigned centroid. **k-Means minimizes inertia**.
*   **Distortion**: Weighted average of squared distances (weighted by cluster size). More formal probabilistic interpretation.
**Choosing Best Run**: Run k-means multiple times (due to random initialization) and select the result with the **lowest inertia**.

![[inertia-vs-distortion.png]]

### Limitations of k-Means (Failure Cases)
Use k-means with caution or avoid when:
1.  **Clusters have different densities or sizes**.
    ![[k-means-fail-1.png]]
2.  **Clusters are non-spherical or elongated** (it assumes isotropic shapes).
    ![[k-means-fail-2.png]]
3.  **Clusters have complex, non-convex shapes**.
    ![[k-means-fail-3.png]]
**Underlying Assumption**: k-means assumes clusters are defined by **centers** and **convex**. It performs **hard assignment** (each point belongs to exactly one cluster).

### Vector Quantization View
**Situation**: k-means can be seen as a **compression** or **decomposition** technique. It represents each data point by its nearest cluster center (**codebook vector**). Useful for **image compression** (color quantization) and **feature engineering**.

## 5.3 Agglomerative Hierarchical Clustering
**Situation**: When you do **not know the number of clusters** in advance, or you want to explore a **hierarchy** of clusterings (from fine to coarse). Also useful when you need a **visual representation (dendrogram)** of the clustering process.

### Algorithm:
1.  **Start**: Each point is its own cluster.
2.  **Merge**: Iteratively merge the **two most similar clusters**.
3.  **Stop**: When a stopping criterion is met (e.g., desired number of clusters, or a distance threshold).
**Linkage Criteria** (Defines "most similar clusters"):
*   **Ward** (default in sklearn): Minimizes variance of the clusters being merged. Tends to create **clusters of equal size**.
*   **Average**: Merges clusters with the smallest **average distance** between all points.
*   **Complete**: Merges clusters with the smallest **maximum distance** between points.
*   **Single**: Merges clusters with the smallest **minimum distance** between points (can lead to "chaining").

![[agglomerative-1.png]]
![[agglomerative-2.png]]

**Python Implementation**:
```python
from sklearn.cluster import AgglomerativeClustering
agg = AgglomerativeClustering(n_clusters=3)
labels = agg.fit_predict(X)  # Note: Cannot predict on new data
```

## 5.4 Dendrograms
**Situation**: The primary tool for **visualizing and interpreting hierarchical clustering** results, especially with multi-dimensional data. Allows you to decide the number of clusters *after* analysis.

**Interpretation**:
*   **Leaves**: Individual data points.
*   **Branches/Nodes**: Represent the merging of clusters.
*   **Y-axis (Height)**: The **distance** at which clusters were merged. Longer branches indicate merges between **dissimilar** clusters.
*   **Cutting the Dendrogram**: Drawing a horizontal line across the tree. The number of vertical lines it intersects = **number of clusters**. Choose a cut where branches are long (indicating distinct clusters).

![[dendogram.png]]

**Python Implementation**:
```python
from scipy.cluster.hierarchy import dendrogram, linkage, ward
# Compute linkage matrix
linkage_matrix = ward(X)  # or linkage(X, method='ward')
# Plot
dendrogram(linkage_matrix)
plt.xlabel("Sample index")
plt.ylabel("Cluster distance")
```

### Limitations of Agglomerative Clustering
*   **Computational Cost**: Generally more expensive than k-means for large N.
*   **No Predictions**: The `fit_predict` method must be used on the entire dataset; the model cannot assign new points to existing clusters.
*   **Shape Assumptions**: Like k-means, it often uses Euclidean distance and linkage criteria that favor convex clusters, so it can also fail on complex shapes.