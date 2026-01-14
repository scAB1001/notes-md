# Lecture 1: Introduction to Data Science
## 1. Core Definition & Scope
> **Data Science** is a multidisciplinary field using principles, algorithms, and processes to extract **nonobvious and useful patterns** from **large data sets**. It encompasses the full **data lifecycle**: capture, cleaning, analysis, modelling, and presentation.

* **Machine Learning (ML)** is a subset focused on algorithmic pattern extraction.
* **Data Mining** typically analyses structured data for discovery.
* **Data Science** includes **unstructured data** (e.g., social media), **big-data technologies**, and **data ethics**.
## 2. Datafication
> **Datafication** is the process of taking all aspects of life and turning them into **quantifiable data**. Once datafied, information can be repurposed into new forms of value.

**Example**: A **fitness tracker** datafies sleep, movement, and heart rate. The resulting data allows a user to derive **actionable insights**, such as linking poor sleep quality to late-night screen time, which would be difficult to notice otherwise.
## 3. Key Skills of a Data Scientist
* **Technical**: Computer Science, Mathematics, Statistics, Machine Learning.
* **Domain Expertise**: Understanding the specific field (e.g., healthcare, film).
* **Soft Skills**: Communication, Presentation, **Data Visualisation**.
## 4. Core Process & Workflow
1.  **Data Collection & Preparation**: **Collecting, Curating, Cleaning**. The most time-consuming phase.
2.  **Analysis & Modelling**: **Visualize, Analyze, Model (Machine Learning)**.
3.  **Critical Questions Before Modelling**:
    *   Does the **past represent the future**? (Assumption for predictive models).
    *   What is the **goal** of the model?
    *   How will it be **used**?
    *   What data is **needed** vs. **available**?
## 5. Example Applications
* **IMDb**: Structured, crowdsourced data enabling questions on actor careers, film success factors (**correlation** between budget/ratings), and societal trends (e.g., age disparity between actors/actresses).
* **Gapminder**: Uses **GDP per capita** (a **metric** for national wealth) to analyse relationships with health outcomes like life expectancy, demonstrating **exploratory data analysis**.
## 6. Historical Context & Greater Data Science (GDS)
* **50-Year Foundation**: Roots in statistics (Tukey, Cleveland) advocating for a broader **data analysis** science beyond theory.
* **Lesser Data Science (LDS)**: Current, narrow commercial focus on **big-data** tools and scalability.
* **Greater Data Science (GDS)**: Donoho's proposed rigorous framework with six divisions:
    1.  Data Exploration & Preparation.
    2.  Data Representation & Transformation.
    3.  Computing with Data.
    4.  Data Modelling (includes both **statistical inference** and **predictive modelling**).
    5.  Data Visualisation & Presentation.
    6.  **Science about Data Science**: Empirical study of data analysis methods themselves.
* **Common Task Framework (CTF)**: Key driver of ML progress; uses public **benchmarks**, shared data, and objective scoring to compare algorithms.
## 7. Core Objectives & Values
* **Primary Goal**: Derive **actionable insights**, not just numbers. Requires asking the **right questions**.
* **Statistical Reasoning Values**: Understanding the **application domain**, appreciating the **small** (details matter), quest for **significance**, hunger for **exploration**.
* **Future Direction**: Evolution towards **evidence-based methodology** via **Science about Data Science**, using meta-analysis of computational research to improve methods.
# Lecture 2: Data Understanding & Profiling
## 2.1 What is Data?
> A **datum** is a single measurement of something on a scale understandable to both recorder and reader.

**Example**: Using the **Titanic dataset** (891 rows, 12 columns) to predict passenger survival based on personal characteristics (age, ticket class, gender). This is a **classification** task.
## 2.2 Data Sources
* **Internal Sources**: Data already collected within an organization (e.g., business operations data, experimental data).
* **Existing External Sources**: Ready-to-use data from outside (e.g., government databases, stock market feeds, Yelp reviews). Accessed via **APIs** (often paid), **RSS feeds**, or downloads.
* **External Sources Requiring Collection**: Data requiring extraction effort (e.g., printed data, website data). **Web scraping** (extracting data from HTML) is a common method.
## 2.3 Web Scraping Considerations
* **Why**: Lack of API, cost avoidance, data availability.
* **Ethical/Legal Concerns**: Violating **Terms of Service**, privacy issues, bypassing paid services. Essential to consider before publishing analysis or products.
## 2.4 Key Data Properties
* **Structure**: The "shape" of a data file (e.g., tabular, **non-rectangular**). Tabular data is standard, with rows as records and columns as fields/variables.
* **Granularity**: The level of detail (e.g., individual people vs. aggregated groups).
* **Scope**: How complete the data is relative to the research question. **Poor scope** leads to inability to answer the question or need for filtering.
* **Temporality**: How data is situated in time. Considerations: collection date, **periodicity** (e.g., diurnal patterns), and the meaning of time fields (event time vs. entry time).
* **Faithfulness**: How well data captures reality. Check for: unrealistic values (future dates, negative counts), violated dependencies (age vs. birthday), data entry errors, default values, duplication, and timezone inconsistencies.
## 2.5 Data Types & Values
**Atomic Types**: Numeric (integers, floats), Boolean, Strings.
**Compound Types**:
* **Date/Time**: Structured temporal data.
* **Lists**: Sequences of values.
* **Dictionaries**: Collections of **key-value pairs** (e.g., `{"First": "Kevin", "Last": "Rader", "Classes": ["CS-109A", "STAT139"]}`).
## 2.6 Handling Missing Data
* **Deletion**: Dropping records with missing values. Risk: introduces **bias** if missingness is not random.
* **Keep as NaN**: Represent missingness explicitly.
* **Imputation**: Inferring missing values.
    * **Average Imputation**: Replace with mean/median (often within a subgroup).
    * **Hot Deck Imputation**: Replace with a random value from similar records.
    * **Regression Imputation**: Replace with a value predicted by a model.
    * **Multiple Imputation**: Create multiple datasets with different imputed values to account for uncertainty.
    * **Essential**: Understand **why data is missing** (Missing Completely at Random - MCAR, Missing at Random - MAR, Missing Not at Random - MNAR).
## 2.7 Data Storage Formats
* **Tabular Data**: Two-dimensional tables (rows=records, columns=variables) -> CSV, Excel.
* **Structured Data**: Records as dictionaries with consistent keys. Formats: JSON, XML.
* **Semi-structured Data**: Records lack uniform structure; some data not in key-value pairs.
## 2.8 Common Issues & Data Cleaning
**Generic Profiling Questions**: Dataset size, completeness, representativeness, presence of outliers/artificial data, uniqueness of identifiers.
**Joining Data**: Use **primary keys** (unique column(s) identifying a record) and **foreign keys** (columns referencing a primary key in another table). `pd.merge` in Pandas performs joins.
**Messy Data Symptoms**: Column headers are values, variables in rows/columns, multiple variables in one column, multiple entity types in one table.
**Tidy Data Principle**: Each file is a dataset, each column a single **variable**, each row a single **observation**.
## 2.9 Hierarchy of Data Categories
![[data-types.png|400]]
* **Quantitative** (intervals have meaning):
    * **Continuous**: Measurable to arbitrary precision (e.g., Price, Temperature).
    * **Discrete**: Finite, countable values (e.g., Number of siblings).
* **Qualitative (Categorical)**:
    * **Ordinal**: Categories with ordered levels, but differences not consistent (e.g., Education level, Shirt size (S,M,L), Yelp star rating).
    * **Nominal**: Categories with no inherent order (e.g., Political affiliation, Race/Ethnicity).
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
* **Data Characterisation**: Understanding what the data *is* (structure, distributions).
* **Data Quality Investigation**: Assessing **fitness for purpose** via:
    * **Completeness** (missing data).
    * **Accuracy** (incorrect/implausible values).
    * **Consistency** (format, units across sources).
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
* **Matplotlib**: Core plotting library. Powerful but has non-intuitive syntax.
* **Pandas**: Data manipulation. Provides high-level plotting wrappers around matplotlib.
* **NumPy**: Foundation for numerical computation (arrays, matrices).
* **Scikit-learn**: Machine learning library (algorithms, utilities, built-in datasets like **Iris**).
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
* **Central Tendency**: `mean` (average), `median` (middle value), `mode` (most frequent).
* **Variability**: `variance` (average squared deviation from mean), `standard deviation` (sqrt of variance), `quantiles` (e.g., 25th percentile = Q1, 75th percentile = Q3).
* **Robust Statistics**: Median and **interquartile range (IQR = Q3 - Q1)** are less sensitive to **outliers** than mean and standard deviation.
* **Outlier Handling**: Can filter using percentiles (e.g., remove data outside IQR) but context is critical (e.g., fraud detection requires keeping outliers).
## 3.6 Key Visualisation Techniques
### Pie Chart
* **Use Case**: Showing proportion of a whole for a **categorical variable**.
* **Data Type**: **Nominal** or **Ordinal**.
* **Example**: Breakdown of Iris species counts in the dataset.
* **Code**: `df.groupby('species').sum().plot(kind='pie')`
### Bar Chart
* **Use Case**: Comparing quantities across **discrete categories**.
* **Data Type**: **Categorical** (Nominal/Ordinal) on one axis, **quantitative** on the other.
* **Example**: Average sepal width per Iris species.
* **Code**: `df.groupby('species').mean().plot(kind='bar')`
### Histogram
* **Use Case**: Visualising the **distribution** of a single **continuous variable**.
* **Data Type**: **Quantitative** (Continuous or Discrete).
* **Example**: Distribution of petal lengths across all flowers.
* **Code**: `df['petal length (cm)'].plot(kind='hist')`
### Box Plot
* **Use Case**: Summarising distribution and identifying **outliers**. Shows median, IQR (box), and whiskers (typically 1.5\*IQR).
* **Data Type**: **Quantitative**.
* **Example**: Comparing sepal length distributions across species.
* **Code**: `df.pivot('ind', 'species')['sepal length (cm)'].plot(kind='box')`
### Scatter Plot
* **Use Case**: Visualising relationship between **two continuous variables**.
* **Data Type**: **Quantitative** vs. **Quantitative**.
* **Enhancements**: Use `color`, `size`, `marker`, `alpha` (transparency) to encode additional dimensions (e.g., species).
* **Example**: Sepal length vs. sepal width, colored by species.
* **Code**: `df.plot(kind='scatter', x='sepal length (cm)', y='sepal width (cm)')`
### Scatter Plot with Logarithmic Axes
* **Use Case**: Data spanning **orders of magnitude**. Reveals patterns obscured on a linear scale.
* **Data Type**: **Positive quantitative** data with wide range.
* **Example**: Crime rate vs. median home value (inverse relationship becomes clear on log scale).
* **Method**: Plot `log(data)` or set `ax.set_xscale('log')`.
### Scatter Matrix (Pairs Plot)
* **Use Case**: Simultaneously visualising pairwise relationships between **multiple numeric features**.
* **Data Type**: **Quantitative**.
* **Output**: Grid of scatterplots and histograms.
* **Example**: Quick assessment of all feature relationships in the Iris dataset.
### Heatmap
* **Use Case**: Visualising **density** or **intensity** in a 2D space, especially useful for large datasets where scatterplots become cluttered.
* **Data Type**: **Quantitative** density derived from two quantitative variables.
* **Example**: Density of data points in petal length vs. petal width space.
### Time Series Plot
* **Use Case**: Analysing data points indexed in **time order** to identify trends, cycles, and anomalies.
* **Data Type**: **Quantitative** values over **time**.
* **Considerations**: Periodicity, overall trend, noise, spikes.
* **Transformations**: Log scale, **Fourier transform** for frequency analysis.
* **Example**: Atmospheric CO2 levels over years, showing yearly cycles and upward trend.
## 3.7 Profiling Studies & Best Practices
* **Core Insight**: Profiling is often **ad-hoc and superficial**. A **structured workflow** (e.g., the 6-step guide) improves rigour.
* **Six-Step Workflow**: 1) Initial look, 2) Find special values, 3) Check missing data, 4) Inspect individual variables, 5) Check variable relationships, 6) Final characterisation.
* **Data Quality Dimensions**: Assess **Completeness** (missingness), **Accuracy** (valid, plausible values), **Consistency** (formats, units).
* **Visualisation for Profiling**: Underutilised for quality checks. Should be used more comprehensively.
* **Tool Support**: Python packages like `vizdataquality` can automate and formalise the profiling process.
# Lecture 4: Machine Learning Overview
## 4.1 Core Definitions & Relationships
> **Data Mining (Knowledge Discovery in Data - KDD)** is the process of uncovering patterns and valuable information from large datasets.

> **Artificial Intelligence (AI)** is the broader field of creating systems that perform tasks requiring human-like intelligence (e.g., learning, reasoning). It has two main approaches:
> * **Top-down (Knowledge-driven)**: Starts with symbolic rules and logic (e.g., Expert Systems).
> * **Bottom-up (Data-driven)**: Uses data to build decision mechanisms mathematically (ML).

> **ML is a subset of AI focused on programming computers to **optimise a performance criterion using example data or past experience**. It combines **Statistics** (inference from a sample) and **CS** (efficient algorithms for optimisation and model evaluation).
## 4.2 When to Use Machine Learning
Use ML when:
1.  **Human expertise does not exist** (e.g., navigating on Mars).
2.  **Humans cannot explain their expertise** (e.g., speech recognition).
3.  **The solution changes over time** (e.g., network routing).
4.  **The solution needs personalisation** (e.g., user biometrics).

**Core Principle**: Learning **general models** from **specific example data**. Data is abundant; knowledge (models) is valuable.
## 4.3 Data Mining vs. Machine Learning
* **Data Mining**: Discovers **existing patterns** in data (descriptive).
* **Machine Learning**: **Learns from past data** to build models for **predicting future outcomes** (predictive). ML is a primary tool used within the KDD process.
## 4.4 Supervised Learning
**Situation**: When you have a dataset of **input/output pairs (labeled data)** and want to predict an output for new inputs.
**Goal**: Learn a **mapping function** from inputs to outputs.
**Training**: Model learns from a **training set** of example pairs.
### Classification
**Situation**: The output is a **categorical label** (class) from a predefined list.
* **Binary Classification**: Two possible classes (e.g., spam/not spam, low-risk/high-risk credit).
* **Multiclass Classification**: More than two classes (e.g., language of a website, digit recognition).
**Example**: Credit scoring. **Inputs**: Income, savings. **Output**: "low-risk" or "high-risk". A **discriminant** function (e.g., `IF income > θ1 AND savings > θ2`) can be learned.
### Regression
**Situation**: The output is a **continuous quantitative value**.
**Goal**: Predict a number.
**Example**: Predicting the steering angle for a self-driving car (**Robot Arm Kinematics**), forecasting house prices, estimating patient recovery time.
![[supervised-unsupervised-tree 1.png|400]]
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
* **Customer Segmentation (CRM)**: Group customers by purchasing behavior.
* **Image Compression**: **Color quantization** by grouping similar pixel colors.
* **Biology**: Grouping genes with similar expression patterns.
![[cluster-ex.png|400]]
## 4.6 Reinforcement Learning
**Situation**: An **agent learns to make decisions by performing actions in an environment to maximise cumulative reward**. It receives **delayed feedback** (reward or penalty), not direct supervision.
**Key Challenge**: **Credit Assignment Problem** – determining which actions led to the received rewards.
**Examples**: Game playing (AlphaGo), robot navigation in a maze, autonomous driving systems.
# Lecture 5: Clustering & Similarity
## 5.1 Data Similarity & Distance Metrics
**Situation**: When you need to quantify how alike (or different) two data points are. This is foundational for **clustering**, **recommendation systems**, and **nearest-neighbor algorithms**.
**Core Idea**: Objects represented as **feature vectors**. Similarity ${\propto}^{-1}$ **distance** in the feature space.
### Euclidean Distance
**Situation**: The most common distance metric, used when data is **continuous** and features are on **comparable scales**. It measures the "straight-line" distance.
**Formula**: For points $p = (p_1, p_2, ..., p_n)$ and $q = (q_1, q_2, ..., q_n)$:
$$
d(p, q) = \sqrt{(p_1 - q_1)^2 + (p_2 - q_2)^2 + ... + (p_n - q_n)^2}
$$
**Example**: Measuring distance between two customers based on their (scaled) annual spending and age.
![[euclidian-dist.png|400]]
## 5.2 k-Means Clustering
**Situation**: When you need to partition data into a **predefined number (k)** of **spherical or convex clusters** of roughly equal size. It is **scalable** to large datasets.
### Algorithm Steps:
1.  **Initialization**: Randomly select **k** data points as initial **cluster centers** (centroids).
2.  **Assignment Step**: Assign each data point to the **closest centroid** (using Euclidean distance).
3.  **Update Step**: Recompute each centroid as the **mean** of all points assigned to it.
4.  **Iteration**: Repeat steps 2 & 3 until **convergence** (assignments no longer change).
![[k-means-cluster-ex.png|400]]
**Python Implementation**:
```python
from sklearn.cluster import KMeans
kmeans = KMeans(n_clusters=3)
kmeans.fit(X)
labels = kmeans.labels_          # Cluster assignments for training data
new_labels = kmeans.predict(X_new) # Assign new points to clusters
```
### Loss Functions: Inertia and Distortion
Each time you run K-Means, you get a different output, depending on where centers started.
To evaluate different clustering results, we need a loss function.
* **Inertia (Within-Cluster Sum of Squares)**: Sum of squared distances of each point to its assigned centroid. **k-Means minimizes inertia**.
* **Distortion**: Weighted average of squared distances (weighted by cluster size). More formal probabilistic interpretation.
**Choosing Best Run**: Run k-means multiple times (due to random initialization) and select the result with the **lowest inertia**.
![[inertia-vs-distortion.png|400]]
### Limitations of k-Means (Failure Cases)
Use k-means with caution or avoid when:
1.  **Clusters have different densities or sizes**.
![[k-means-fail-1.png|400]]
2.  **Clusters are non-spherical or elongated** (it assumes isotropic shapes).
![[k-means-fail-2.png|400]]
3.  **Clusters have complex, non-convex shapes**.
![[k-means-fail-3.png|400]]
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
* **Ward** (default in sklearn): Minimizes variance of the clusters being merged. Tends to create **clusters of equal size**.
* **Average**: Merges clusters with the smallest **average distance** between all points.
* **Complete**: Merges clusters with the smallest **maximum distance** between points.
* **Single**: Merges clusters with the smallest **minimum distance** between points (can lead to "chaining").
![[agglomerative-1.png|700]]
![[agglomerative-2.png|700]]
**Python Implementation**:
```python
from sklearn.cluster import AgglomerativeClustering
agg = AgglomerativeClustering(n_clusters=3)
labels = agg.fit_predict(X)  # Note: Cannot predict on new data
```
![[hierarchical-clustering.png|300]]
## 5.4 Dendrograms
The primary tool for **visualizing and interpreting hierarchical clustering** results, especially with multi-dimensional data. Allows you to decide the number of clusters *after* analysis.

**Interpretation**:
* **Leaves**: Individual data points.
* **Branches/Nodes**: Represent the merging of clusters.
* **Y-axis (Height)**: The **distance** at which clusters were merged. Longer branches indicate merges between **dissimilar** clusters.
* **Cutting the Dendrogram**: Drawing a horizontal line across the tree. The number of vertical lines it intersects = **number of clusters**. Cuts across long branches show **distinct** clusters.
![[dendogram.png|440]]
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
* **Computational Cost**: Generally more expensive than k-means for large N.
* **No Predictions**: The `fit_predict` method must be used on the entire dataset; the model cannot assign new points to existing clusters.
* **Shape Assumptions**: Like k-means, it often uses Euclidean distance and linkage criteria that favor convex clusters, so it can also fail on complex shapes.
# Lecture 6: Classification, k-NN, & Decision Trees
## 6.1 Classification Problem Definition
> **Classification** is a **supervised learning** task where the goal is to predict a **categorical label (class)** for a given input, based on a model learned from a dataset of **input-output pairs (labeled data)**.

**Example Context: Iris Species Classification**
* **Inputs (Features)**: Sepal length/width, petal length/width (continuous measurements).
* **Output (Label/Class)**: Species of iris: *setosa*, *versicolor*, or *virginica*.
* **Problem Type**: **Three-class classification**.
* **Goal**: Build a model from known data (training set) to predict the species of new iris flowers.
## 6.2 Training and Testing Data
To evaluate a model's ability to **generalize** to unseen data, we must split our labeled dataset.
* **Training Set**: Used to **build/train** the machine learning model (e.g., 75% of data).
* **Test Set (Hold-out Set)**: Used to **assess** the model's performance on new data (e.g., 25% of data).
**Crucial Step**: **Shuffle** the data before splitting to ensure the test set contains examples from all classes, preventing bias.

**Python (scikit-learn)**:
```python
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.25, 
													random_state=42, stratify=y)
```
## 6.3 k-Nearest Neighbors (k-NN) Classifier
> **k-NN** is a **lazy**, instance-based learning algorithm that classifies a new data point based on the **majority class** among its **k closest training examples** in the feature space.

Useful for simple, interpretable classification, especially when the decision boundary is irregular. It makes **no assumptions** about the data distribution. Can be sensitive to the **curse of dimensionality**.
### Algorithm Steps:
1.  **Choose k**: The number of nearest neighbors (typically odd for binary classification).
2.  **Calculate Distance**: Compute distance (e.g., **Euclidean**) from the query point to all training points.
3.  **Identify Neighbors**: Select the **k** training points with the smallest distances.
4.  **Vote for Label**: Assign the most common class among the **k neighbors**.

| step 1                   | step 2                     | step 3              |
| ------------------------ | -------------------------- | ------------------- |
| ![[iris-knn-1.png\|290]] | ![[iris-knn-2 1.png\|300]] | ![[iris-knn-3.png]] |
**Advantages**:
* **Simple** to understand and implement.
* **No training phase** (stores the training data).
*   Naturally handles **multi-class** problems.
*   Can model **complex decision boundaries** if k is small.

**Disadvantages**:
* **Computationally expensive at prediction time** (compute distances to all training points).
* **Sensitive to irrelevant features** and the **scale** of features (requires scaling).
* **Performance degrades with high dimensionality** (curse of dimensionality).
* **Choice of k is critical**: Small k leads to **high variance/noise sensitivity**; large k leads to **high bias/oversmoothing**.
## 6.4 Decision Tree Classifier
> A **Decision Tree** is a supervised learning model that predicts a target label by learning simple **decision rules** inferred from the data features. It splits the data into subsets based on feature values, forming a tree-like structure.

**Situation**: Useful when you need an **interpretable, white-box model**. Handles both numerical and categorical data. Prone to **overfitting** if not regularized.
### Building a Tree: The Algorithm
1.  **Start**: All data at the **root node**.
2.  **Find Best Split**: For each feature, find the **split value** that best separates the data into purer child nodes. The "best" split minimizes **impurity**.
3.  **Split**: Create child nodes based on the rule (e.g., `petal_width < 0.8 cm`).
4.  **Repeat**: Recursively apply steps 2-3 to each child node until a **stopping criterion** is met (node is pure, node is unsplittable, max depth reached).
![[iris-decision-tree.png|300]]
### Impurity Measures: Entropy & Gini
To quantify the "goodness" of a split, we measure the **impurity** of a node.
>**Entropy** is an impurity measure based on information theory. For a node with class proportions $p_c$, it is defined as: 
$$S = -\sum_{c} p_c \log_2 p_c$$
>**Low entropy**: the node is pure (predictable). **High entropy**: node is mixed (unpredictable).

> **Gini Impurity** is another common measure: $G = 1 - \sum_c p_c^2$. It measures the probability of misclassifying a randomly chosen element.

**Choosing the Best Split**: We select the feature and split value that result in the **maximum reduction in impurity** (or **minimum weighted impurity**) across the child nodes.$$\text{Loss (Weighted Impurity)} = \frac{N_{left} \cdot S_{left} + N_{right} \cdot S_{right}}{N_{left} + N_{right}}$$The split with the **lowest loss** is chosen.
![[entropy-ex.png|400]]
For example, S for the top node is:
$−0.31 \cdot log_2(0.31) − 0.33 \cdot log_2(0.33) − 0.36 \cdot log_2(0.36) = (0.52 + 0.53 + 0.53) = 1.58$
### Visualizing Decision Trees & Boundaries
* **Tree Structure**: Can be visualized to understand the decision rules (using `plot_tree`).
* **Decision Boundary**: Creates **axis-aligned, rectangular partitions** of the feature space, leading to a **nonlinear, piecewise-constant** boundary.

|                                 |                                            |
| ------------------------------- | ------------------------------------------ |
| ![[decision-tree-vis.png\|400]] | ![[iris-decision-scatter-scikit.png\|400]] |
### Overfitting in Decision Trees
**Situation**: A tree that grows too deep will create complex rules to fit the **training data perfectly**, including its noise. This model will have **high variance** and perform poorly on new data (low generalization).

**Signs of Overfitting**:
*   100% accuracy on training set.
*   Very deep tree with many nodes.
*   Rules that seem overly specific (e.g., `petal_length < 4.800001`).

**Mitigation Strategies (Regularization)**:
* **Limit tree depth** (`max_depth`).
* **Set a minimum number of samples** required to split a node (`min_samples_split`).
* **Set a minimum number of samples** in a leaf node (`min_samples_leaf`).
* **Use pruning** (remove nodes that provide little power).
### Advantages & Disadvantages of Decision Trees

**Advantages**:
* **Simple to understand and interpret** (white box model).
* **Requires little data preparation** (handles mixed data, robust to outliers).
* **Nonparametric** (makes no assumptions about data distribution).
*   Can model **nonlinear relationships**.

**Disadvantages**:
* **Prone to overfitting**, especially with deep trees. **Requires careful tuning** (pruning, depth limits).
* **Unstable**: Small variations in data can lead to a completely different tree.
* **Biased towards features with more levels**.
*   Not ideal for **extrapolation** (predicting outside the range of training data).
*   The **axis-aligned splits** can be inefficient for modeling some relationships compared to models that can create oblique splits.
# Lecture 7: Regression, Overfitting, and Random Forests
## 7.1 Regression Definition
> **Regression** is a **supervised learning** task where the goal is to predict the value of one or more **continuous target variables** $t$ given a $D$-dimensional vector of input variables $x$. The model learns a mapping from inputs to a real-valued output.

**Situation**: Used when the target is a quantity (e.g., price, temperature, coordinate). Contrast with **classification**, where the target is categorical.
**Example**: Predicting house prices from size/location (**regression**) vs. predicting if a house will sell (yes/no) (**classification**).
## 7.2 Linear Regression & Model Fitting
The simplest model is **linear regression**: $y = mx + b$, where $y$ is the prediction, $m$ is the slope, $b$ is the intercept.
### Least Squares Fitting
**Situation**: The standard method for fitting a linear model. It finds parameters ($m$, $b$) that minimize the **sum of squared errors (SSE)** between predictions and true values.
**Penalty/Loss Function**:$$L = \sum_{i} (y_i - (mx_i + b))^2$$**Advantages**:
*   Has a **closed-form solution** (can be solved analytically).
*   Optimal if errors are **normally distributed**.
**Disadvantage**: **Highly sensitive to outliers** because errors are squared, giving large deviations disproportionate influence.
### L1 Regression (Absolute Error)
**Situation**: An alternative more **robust to outliers**. Minimizes the sum of absolute errors.
**Penalty Function**:$$L = \sum_{i} |y_i - (mx_i + b)|$$**Advantages**:
*   More **robust**; outliers have less influence.
**Disadvantages**:
* **No closed-form solution**; computationally more complex.
*   Penalizes small deviations more harshly relative to least squares.
## 7.3 Nonlinear Curve Fitting & Polynomial Regression
**Situation**: When the relationship between input and output is not linear. We can fit more complex functions (e.g., exponential decay, logistic growth, polynomials).

**Polynomial Regression Model**:$$y(x, w) = w_0 + w_1x + w_2x^2 + ... + w_Mx^M = \sum_{j=0}^{M} w_j x^j$$
* **Linear in parameters** $w$ (a **linear model**), but **nonlinear in $x$**.
*   $M$ is the **polynomial order** (model complexity).
### Error Function & Root-Mean-Square Error (RMSE)
We minimize the **sum-of-squares error**:$$E(w) = \frac{1}{2} \sum_{n=1}^{N} \{ y(x_n, w) - t_n \}^2$$To compare models across different dataset sizes, use the **Root-Mean-Square Error (RMSE)**:
$$E_{RMS} = \sqrt{ \frac{E(w^*)}{N} }$$
## 7.4 Overfitting in Model Selection
A critical problem where a model learns the **noise** or random fluctuations in the **training data** to such an extent that it performs poorly on new, unseen data (**fails to generalize**).

**Key Symptom**: **Low training error, but high test error**. The model has **high variance**.
![[regression-interp-orders-of-m.png|400]]
**Illustration with Polynomial Order $M$**:
* **$M=0$ or $M=1$ (Underfitting)**: Model is too simple (**high bias**). Poor fit to both training and test data.
* **$M=3$**: A good balance. Captures the underlying trend `sin(2πx)` without fitting the noise.
* **$M=9$ (Overfitting)**: Model is too complex. Training error is zero (fits all points exactly), but test error is very high. The curve **oscillates wildly**.
### How to Prevent Overfitting in Regression
1.  **Use a Simpler Model**: Reduce polynomial order $M$ (reduce model capacity).
2.  **Get More Data**: As shown, increasing $N$ (data points) reduces overfitting for a fixed $M=9$ model.
3.  **Regularization**: Add a penalty term to the loss function that discourages large coefficient values (e.g., Ridge/Lasso regression).
## 7.5 Overfitting in Decision Trees & Prevention
**Situation**: A **fully grown** decision tree (splitting until nodes are pure) will **always overfit** the training data. It creates overly complex, **high-variance** rules.

**Example**: Using only sepal data for iris classification leads to erratic, complex decision boundaries and poor test accuracy (~70%).
### Strategies to Restrict Tree Complexity (Prevent Overfitting)
**Approach 1: Prevent Growth (Pre-pruning)**. Set constraints *during* tree building:
*   `max_depth`: Maximum depth of the tree.
*   `min_samples_split`: Minimum number of samples required to split a node.
*   `min_samples_leaf`: Minimum number of samples required in a leaf node.
*   `max_features`: Number of features to consider for the best split.

**Approach 2: Pruning (Post-pruning)**. Grow the tree fully, then *remove* branches that provide little predictive power.
* **Method**: Use a **validation set**. If replacing a subtree with a leaf node (predicting the majority class) does not increase validation error, prune it.
## 7.6 Random Forests
> A **Random Forest** is an **ensemble learning** method that constructs a multitude of decision trees during training and outputs the **mode** (for classification) or **mean** (for regression) of the predictions of the individual trees. It reduces overfitting by averaging multiple **high-variance** models.

**Core Idea**: **Bootstrap Aggregating (Bagging)** + **Random Feature Subsets**.
1.  **Bagging (Bootstrap Aggregating)**: Create many **bootstrap samples** (random samples with replacement) from the training data. Train a separate decision tree on each sample.
2.  **Random Feature Selection**: At each split in a tree, only consider a **random subset of $m$ features** (typically $m = \sqrt{p}$ for classification). This **decorrelates** the trees.

**Prediction**: For a new point, collect predictions from all trees and take the **majority vote** (classification) or **average** (regression).
![[random-forest-9-models.png|400]]
### Advantages of Random Forests
* **Reduces Overfitting**: By averaging many trees, it reduces the **high variance** of a single decision tree.
* **Versatile**: Handles both **classification and regression**.
* **Robust**: Less sensitive to outliers and irrelevant features than single trees.
* **Automatic Feature Selection**: The random feature subsetting naturally evaluates feature importance.
* **Requires Less Tuning**: Often works well with default parameters.
* **Nonlinear**: Can capture complex interactions without explicit feature engineering.
### Disadvantages of Random Forests
* **Less Interpretable**: A "black box" compared to a single decision tree.
* **Computationally Expensive**: Training many trees is slower than training one tree.
* **Memory Intensive**: Requires storing all the individual trees.
## 7.7 Decision Trees for Regression
**Situation**: Decision trees can also be used for **regression** tasks. Instead of predicting a class at a leaf node, they predict a **continuous value** (typically the **mean** of the target values of the training samples in that leaf).

**Process**:
* **Splitting Criterion**: Minimize the **variance** (or MSE) within the child nodes, not entropy/Gini impurity.
* **Prediction**: The output for a region is the average target value of training points in that region.

**Advantage**: Can model **piecewise constant** functions and complex, nonlinear relationships.
**Disadvantage**: Prone to the same **overfitting** issues as classification trees, requiring the same regularization techniques (pruning, random forests).
# Lecture 8: Model Evaluation
## 8.1 Making Predictions & Baseline Evaluation
**Situation**: After training a model (e.g., k-NN on Iris), we need to **predict** on new, unseen data and **evaluate** how trustworthy the model is.
**Process**:
1.  Use `.predict()` on the model with new feature data.
2.  For **initial evaluation**, compare predictions on the **test set** (data not used in training) to the true labels.
**Key Metric (Initial)**: **Accuracy**.
$$ \text{Accuracy} = \frac{\text{Number of Correct Predictions}}{\text{Total Number of Predictions}} $$
**Limitation**: Accuracy can be **misleading for imbalanced datasets** (e.g., a model that always predicts the majority class will have high accuracy but is useless).
## 8.2 The Confusion Matrix
**Situation**: A **detailed breakdown** of prediction errors, essential for **binary** and **multiclass classification**, especially with **imbalanced classes**.

**Structure (Binary Case)**:

|                 | Predicted: NO       | Predicted: YES      |
| --------------- | ------------------- | ------------------- |
| **Actual: NO**  | True Negative (TN)  | False Positive (FP) |
| **Actual: YES** | False Negative (FN) | True Positive (TP)  |
![[confusison-matrix.png|340]]
### Key Derived Metrics
>**Precision** answers: "**Of all instances predicted as positive, how many are actually positive?**" It focuses on **minimizing False Positives (FP)**.
$$\text{Precision} = \frac{TP}{TP + FP}$$
> **Use when**: The cost of a **false alarm (FP)** is high (e.g., spam detection, fraud alert).
> **Recall (Sensitivity, True Positive Rate - TPR)** answers: "**Of all actual positive instances, how many did we correctly identify?**" It focuses on **minimizing False Negatives (FN)**.
$$\text{Recall} = \frac{TP}{TP + FN}$$
> **Use when**: Missing a positive case (FN) is costly (e.g., disease screening, search engine results).
> **Specificity (True Negative Rate - TNR)** answers: "**Of all actual negative instances, how many did we correctly identify?**"
$$\text{Specificity} = \frac{TN}{TN + FP}$$
> **Use when**: Correctly identifying negatives is critical.
### The Precision-Recall Trade-off
**Situation**: It is typically impossible to maximize **both** precision and recall simultaneously. Increasing one often decreases the other (e.g., a more conservative classifier has higher precision but lower recall).
### The F1 Score
**Situation**: Provides a **single metric** that balances both precision and recall, using their **harmonic mean**. Useful when you need a single number to compare models and when there is an **imbalanced class distribution**.
$$F1 = \frac{2 \cdot \text{Precision} \cdot \text{Recall}}{\text{Precision} + \text{Recall}} = \frac{2}{\frac{1}{\text{Precision}} + \frac{1}{\text{Recall}}}$$
* **High F1** indicates both high precision and high recall.
* **Use when**: You want to find a **balance** between precision and recall and the class distribution is uneven.
## 8.3 Cross-Validation
**Situation**: A **robust technique** for model evaluation and selection that provides a better estimate of generalization performance than a single train/test split. It maximizes data usage for both training and validation.
### k-Fold Cross-Validation
**Process**:
1.  Randomly split the data into **k** equal-sized **folds**.
2.  For each fold *i*:
    *   Use fold *i* as the **validation set**.
    *   Use the remaining **k-1** folds as the **training set**.
    *   Train the model and evaluate it on the validation set.
3.  The final performance metric is the **average** of the *k* validation scores.
![[cross-validation.png|340]]
**Advantages**:
* **Reduces variance** in performance estimation compared to a single split.
* **Uses data more efficiently** (every data point is used for both training and validation).
*   Helps detect **overfitting** (if training score is much higher than validation scores).
**Disadvantages**:
* **Computationally expensive** (trains the model *k* times).
*   Not suitable for **temporal data** (where time ordering matters; use time-series splits instead).

**Common Choice**: **k=5** or **k=10**.
# Lecture 9: Dimensionality Reduction
## 9.1 Understanding Dimensionality
> **Dimensionality** of a dataset is the number of independent attributes (features) needed to represent each observation. Mathematically, it is equivalent to the **rank** of the data matrix (the maximum number of linearly independent columns).

**Situation**: Real-world data often has many features (high $d$), but many features may be **redundant** or correlated, meaning the *intrinsic* dimensionality is lower than $d$. Identifying this is key for simplification and analysis.

**Example**: A table with `Height`, `Weight (lbs)`, `Weight (kg)`, `Age`. The two weight columns are linearly dependent (`Weight (kg) ≈ 0.454 * Weight (lbs)`). The **rank** is 3, not 4, because one feature adds no new independent information.

**Key Insight**: If features are perfectly linearly related, the data matrix rank is less than the number of columns. This **redundancy** wastes storage and can confuse some algorithms. Dimensionality reduction aims to find a **lower-rank approximation** that captures the essential information.
## 9.2 The Challenge of High Dimensions
**Situation**: Visualizing and analyzing data becomes difficult when $d > 2$ or $3$. While we can use color, size, or animation for a 4th or 5th dimension, this approach quickly fails.

**Common Need**: To visualize **clusters** or relationships, we often need to **project** data down to 2 or 3 dimensions.
* **Naive Approach**: Simply pick the 2 features with the highest variance. This can work but may miss important patterns captured by combinations of features.
* **Better Approach**: Use techniques like **Principal Component Analysis (PCA)**, which finds the **best** lower-dimensional projection to preserve variance or structure.
## 9.3 Singular Value Decomposition (SVD) - Conceptual Foundation
> **Singular Value Decomposition (SVD)** is a fundamental matrix factorization technique. For any $m \times n$ real matrix $X$, SVD factorizes it into three matrices: $X = U \Sigma V^T$, where $U$ and $V$ are orthogonal matrices (with orthonormal columns/rows), and $\Sigma$ is a diagonal matrix of **singular values** in descending order.

**Intuition**: SVD automatically discovers the **underlying structure** and **redundancies** in your data. It re-expresses the data in a new coordinate system (the columns of $V$, called **principal components**) where the first axis points in the direction of greatest variance, the second in the next greatest orthogonal direction, and so on.
![[svd.png|400]]
### 9.3.1 The Components of SVD
1.  **$U$ (Left Singular Vectors)**: An $m \times m$ orthogonal matrix. Its columns form an **orthonormal basis** for the column space of $X$. In a data context (where rows are samples), $U\Sigma$ represents the coordinates of your data in the new PCA space.
2.  **$\Sigma$ (Singular Values)**: An $m \times n$ diagonal matrix. Its diagonal entries $\sigma_1 \geq \sigma_2 \geq ... \geq \sigma_r > 0$ are the **singular values**, where $r$ is the rank of $X$. They indicate the "importance" or "magnitude" of each corresponding principal component. A singular value of **zero** means that dimension is perfectly redundant.
$$\Sigma = \begin{bmatrix}
\sigma_1 & 0 & \dots & 0 \\
0 & \sigma_2 & \dots & 0 \\
\vdots & \vdots & \ddots & \vdots \\
0 & 0 & \dots & \sigma_r \\
\end{bmatrix}$$
3.  **$V^T$ (Right Singular Vectors, Transposed)**: An $n \times n$ orthogonal matrix. Its **rows** (columns of $V$) are the **principal components** (PCs). They form an orthonormal basis for the row space of $X$ and define the new axes. $V^T$ is the **transformation matrix** that maps the original data ($X$) into the new space ($U\Sigma$).

**Orthonormal Set Property**: The columns of $U$ and $V$ are **unit vectors** (length 1) and **orthogonal** (perpendicular, dot product = 0). This means $U^T U = I$ and $V^T V = I$.
## 9.4 Low-Rank Approximation via SVD
**Situation**: We have noisy, high-dimensional data that is *approximately* low-rank. We want a simpler representation that removes noise and redundancy.

**Process**: Since singular values are ordered by importance, we can create a **rank-$k$ approximation** $X_k$ of the original matrix $X$ by keeping only the first $k$ columns of $U$, the first $k$ singular values in $\Sigma$, and the first $k$ rows of $V^T$:$$X \approx X_k = U_k \Sigma_k V_k^T$$
where $U_k$ is $m \times k$, $\Sigma_k$ is $k \times k$, and $V_k^T$ is $k \times n$.
![[rank3-data.png|440]]
**Interpretation**:
* **Rank-1 Approximation ($k=1$)**: Represents all data points as lying along a single line (the first principal component). All variation is attributed to one latent factor. For the rectangle example, it found a rough relationship like `Area ≈ 3*(Width + Height)`.
* **Rank-3 Approximation ($k=3$)**: For the noisy rectangle data (true rank ~4), a rank-3 approximation captures almost all the systematic variation while filtering out the noise in the 4th, least important dimension.
* **Choosing $k$**: Look at the **singular value spectrum**. A large drop indicates that subsequent components contribute little information. You choose $k$ to retain, say, 95% or 99% of the total variance (calculated from squared singular values).

**Why it's Powerful**: SVD provides the **optimal** low-rank approximation in terms of the Frobenius norm (a measure of matrix difference). It automatically finds the best lower-dimensional subspace to project your data onto.
## 9.5 SVD vs. Manual Decomposition
**Manual Decomposition (Example)**: For the noiseless rectangle data, we could manually see that `Perimeter = 2*Width + 2*Length` and create a 3D to 4D transformation matrix. This is **exact** but requires human insight.
![[trunc-data-and-matrix.png|400]]
**SVD Decomposition**: Does this automatically and more generally. It doesn't necessarily yield human-interpretable features like "width" and "length" in the reduced space ($U\Sigma$). Instead, it yields abstract **principal components** that are linear combinations of original features. For the noiseless case, SVD would yield a singular value of **0** for the redundant dimension, clearly identifying it.
![[svd-applied.png|400]]
**Key Difference**: SVD's output ($U$, $\Sigma$, $V^T$) is mathematically unique (up to sign) and optimal. The reduced data $U\Sigma$ is in a rotated, scaled coordinate system aligned with directions of maximum variance, not the original feature axes.
# Lecture 10: Principal Component Analysis (PCA)
## 10.1 PCA: Definition and Goal
> **Principal Component Analysis (PCA)** is a linear dimensionality reduction technique that transforms data into a new coordinate system such that the greatest variance by any projection of the data comes to lie on the first coordinate (the **first principal component**), the second greatest variance on the second coordinate, and so on. It is achieved by performing **Singular Value Decomposition (SVD)** on the **mean-centered** data matrix.

**Core Idea**: PCA finds the **best lower-dimensional linear subspace** (like a line or plane) onto which to project high-dimensional data, aiming to **preserve as much of the data's variance** (i.e., spread) as possible. This allows for visualization, noise reduction, and more efficient computation.

**Two Equivalent Goals**:
1.  **Maximize Captured Variance**: Find the directions (axes) that retain the maximum spread of the data points.
2.  **Minimize Projection Error**: Find the directions that minimize the squared distance between the original data points and their projections onto the lower-dimensional subspace.

These goals are **dual**: maximizing the variance of the projections is equivalent to minimizing the reconstruction error (the length of the "springs" connecting points to the projection line).
## 10.2 The PCA Procedure
**Step 1: Center the Data**.
This is **crucial**. For each feature (column), subtract the column's mean from every value. This translates the data so its mean is at the origin. Without centering, the first principal component would be biased towards the direction of the mean, not the direction of maximum variance.$$X_{\text{centered}} = X - \bar{X}$$
**Step 2: Perform SVD on the Centered Matrix**.
Compute the SVD: $X_{\text{centered}} = U \Sigma V^T$.
* **$V^T$ (Rows are Principal Directions)**: The **rows** of $V^T$ (or columns of $V$) are the **principal directions** (axes). The first row is the direction of the **1st Principal Component (PC1)**, the second row is **PC2**, etc. They are orthonormal vectors in the original feature space.
* **$U\Sigma$ (Columns are Principal Components)**: The **columns** of $U\Sigma$ (or equivalently, $X_{\text{centered}} V$) contain the **principal component scores** for each data point. Column 1 holds the score for PC1 for all observations, Column 2 for PC2, etc. This is the transformed, lower-dimensional data.

**Step 3: Choose the Number of Components $k$**.
Examine the **singular values** ($\sigma_i$, the diagonal entries of $\Sigma$). The variance captured by the $i$-th PC is $\sigma_i^2 / N$. To decide $k$:
* **Scree Plot**: Plot the variance (or singular values) associated with each PC in descending order. Look for an "elbow" point where the curve bends; components after this add little explanatory power.
* **Cumulative Variance**: Choose $k$ such that the retained PCs explain a sufficiently high proportion (e.g., 95%) of the total variance:
$$\frac{\sum_{i=1}^{k} \sigma_i^2}{\sum_{i=1}^{r} \sigma_i^2} \geq 0.95$$
**Step 4: Project the Data (Dimensionality Reduction)**.
To reduce to $k$ dimensions, keep only the first $k$ columns of $U\Sigma$ (the scores). This $N \times k$ matrix is your reduced-dimension data. You can also compute it as:
$$
X_{\text{reduced}} = X_{\text{centered}} \cdot V_k
$$
where $V_k$ contains the first $k$ columns of $V$ (the top $k$ principal directions).
## 10.3 Geometric Interpretation & Visualization
Consider 2D data (e.g., Child Mortality vs. Fertility Rate).
* **PC1 Direction**: The line through the origin that best fits the "cloud" of data points, minimizing the perpendicular distances (red lines). It is the direction of **maximum variance**.
* **PC2 Direction**: Orthogonal to PC1, capturing the next largest remaining variance. It often represents deviations from the main trend.
* **Rank-1 Approximation**: Projecting all points onto the PC1 line. This gives each country a single **PC1 score** (its position along the line). The approximation for a point is found by mapping its PC1 score back along the PC1 direction (plus the mean).
![[mortality-fertility-vis-pc.png|300]]
**Key Insight**: PCA provides a **new coordinate system**. In the 2D example, instead of describing a country by (Mortality, Fertility), we describe it by (PC1_Score, PC2_Score). Often, PC1_Score alone (a 1D summary) captures the dominant global pattern (e.g., overall development level), while PC2_Score captures more specific, orthogonal variations.
## 10.4 PCA vs. Linear Regression
It's vital to distinguish PCA from fitting a regression line.

| Aspect        | Linear Regression                                                                                                    | Principal Component Analysis (PCA)                                                                                        |
| :------------ | :------------------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------ |
| **Goal**      | Predict a **target variable** $Y$ from a **feature** $X$. Minimizes error **in $Y$ direction** (vertical distances). | **Describe the data** itself. No distinction between features/targets. Minimizes **perpendicular distances** to the line. |
| **Asymmetry** | Direction matters. Regressing $Y$ on $X$ gives a different line than regressing $X$ on $Y$.                          | Symmetric. Treats all variables equally.                                                                                  |
| **Lines**     | For 2D data, you get two different regression lines.                                                                 | You get a **single line** that is a compromise between the two regression lines.                                          |
| **Output**    | A predictive model for a specific variable.                                                                          | A new set of orthogonal axes (PCs) for the entire dataset.                                                                |
![[mortality-fertility-vis-svd.png|300]]
**Simple Analogy**: If you hammer nails (data points) into a board, linear regression is like fitting a ruler to predict nail height from horizontal position. PCA is like finding the best single tight string to which all nails are closest *perpendicularly*.
## 10.5 When to Use PCA
**Use PCA for Exploratory Data Analysis (EDA) when**:
1.  You want to **visualize high-dimensional data** in 2D/3D to identify clusters, outliers, or trends.
2.  You suspect the data is **inherently low-rank** (many features are linear combinations of a few latent factors).
3.  You need to **reduce noise** or compress data before applying other algorithms (a preprocessing step).
4.  You want to **decorrelate features** (PCs are orthogonal by construction).

**Do NOT use PCA as a default preprocessing step if**:
1.  You are in the final modelling stage for a **supervised task** (prediction). Feature selection or regularization (like Lasso) might be more appropriate as PCA can obscure interpretability.
2.  The **meaning of individual features** is critically important for your analysis.
3.  The relationships in your data are **highly nonlinear** (consider t-SNE or UMAP instead).
## 10.6 Advantages and Disadvantages of PCA
**Advantages**:
* **Dimensionality Reduction**: Effectively reduces the number of variables, combating the **curse of dimensionality**.
* **Noise Reduction**: By discarding low-variance components (often associated with noise), it can improve model performance.
* **Decorrelates Features**: Output PCs are orthogonal, removing multicollinearity.
* **Visualization**: Enables plotting of high-dimensional data.
* **Unsupervised**: Requires no labels.

**Disadvantages**:
* **Linear Assumption**: PCA only captures **linear relationships**. It fails for complex nonlinear manifolds.
* **Interpretability**: Principal components are linear combinations of all original features, making them often hard to interpret.
* **Scale Sensitivity**: Results are influenced by the scale of variables. **Features must be standardized** (centered and scaled to unit variance) if they are on different units, otherwise high-variance features dominate PC1.
* **Variance ≠ Importance**: Directions of maximum variance may not be the most important for a specific predictive task.
* **Outlier Sensitivity**: Since it maximizes variance, outliers can disproportionately influence the principal directions.
# Lecture 11: Ethics and Data Governance
## 11.1 What is Ethics?
> **Ethics** is a systematic way of deciding what we **should and should not do**, by evaluating our actions and choices, assessing the reasons behind our judgments, and aiming to act accordingly. It seeks to uphold people's **moral rights** (distinct from legal rights) and **wellbeing** (welfare, happiness, quality of life).

**Purpose**: To develop a **consistent and sound set of principles** to guide action, especially in situations where our immediate intuitions are unclear or conflicting.

**Methodology (The Trolley Problem Example)**:
1.  **Identify Intuition**: e.g., "It seems better to pull the lever to save five lives, sacrificing one."
2.  **Articulate Reason**: e.g., "Saving more lives is morally better."
3.  **Test and Refine**: Apply the reason to similar cases (e.g., the **Fat Man Bridge** variant). If the reason leads to an action that feels deeply wrong (pushing the fat man), we must **interrogate and refine the principle** (e.g., adding "...but we must not directly harm an innocent bystander"). This process of **refining principles** based on reasoned analysis of cases is the core of doing ethics.

**Key Ethical Concepts**: **Fairness**, **Responsibility**, **Duty**, **Harm/Welfare**, **Rights**.
## 11.2 Why Data Science Raises Ethical Issues
**Core Reason**: Data science involves **extracting knowledge about people** from data. With knowledge comes the **power to affect them**, often in ways that are **unpredictable** due to data linkage and unforeseen uses.

* **Historical Precedent**: Technology often creates new ethical challenges (e.g., photography leading to a "right to be let alone").
* **Data-Specific Risks**:
    * **Harm to Subjects**: Breaches of **privacy**, lack of **consent**, insecure handling.
    * **Usage Issues**: **Bias** in tools/interpretations, "**black box**" opacity, loss of human control.
    * **Societal Externalities**: Shaping preferences, sustainability costs, altering interpersonal relations, automation's impact on work.

**The Rebecca Schaeffer Case (1989)**: A stalker used motor vehicle records to find an actress's address, leading to her murder. This illustrates how **seemingly benign data can be linked to cause grave harm**, prompting legal change (Driver’s Privacy Protection Act).
## 11.3 The Relationship Between Ethics and Law
**Ethics and law are related but distinct**.
* **Ethics** determines **moral** rights and obligations based on impacts on others.
* **Law (ideally)** provides enforceable rules to restrict harmful behaviour, protect rights, and implement a society's ethical viewpoint.

**Why "Just Follow the Law" is Insufficient**:
1.  Laws can be **unethical, incomplete, or lag behind technology**.
2.  To **interpret and apply laws** (which contain ethical concepts like "fairness"), ethical reasoning is required.
3.  Some unethical acts (e.g., lying to a friend) are not, and should not be, illegal.
## 11.4 Data Protection Law: UK-GDPR & DPA 2018
The UK General Data Protection Regulation (UK-GDPR) and Data Protection Act 2018 establish the legal framework for handling personal data.
### Key Roles and Definitions
> A **Data Controller** determines the **purposes and means** of processing personal data.
> A **Data Processor** processes personal data **on behalf of** the controller.
> A **Data Subject** is the individual whom the personal data is about.
*(A single entity can be both a controller and a processor for different data flows.)*
> **Personal Data** is any information relating to an identified or **identifiable** living individual. Identifiability can be direct or through linkage with other information.
> **Special Category Data** is personal data revealing **sensitive** aspects (e.g., racial/ethnic origin, political opinions, health data, biometric data). Processing this requires a higher legal justification.

**Example (E4)**: A dataset of house sale prices and exact addresses in Leeds **could be** personal data. While about houses, linkage with other public records (e.g., electoral register) could identify the individuals who lived there.
### The Seven UK-GDPR Principles (Article 5)
Personal data must be processed:
1.  **Lawfully, fairly and transparently**.
2.  **For specified, explicit and legitimate purposes** (purpose limitation).
3.  **Adequate, relevant and limited** to what is necessary (data minimisation).
4.  **Accurate** and, where necessary, kept up to date.
5.  **Kept for no longer than necessary** (storage limitation).
6.  **Processed securely** (integrity and confidentiality).
7.  The controller is **accountable** for complying with these principles.
### Key Data Subject Rights
Subjects have rights including: to be **informed**, to **access** their data, to **rectification**, to **erasure** ("right to be forgotten"), to **restrict processing**, to **data portability**, and to **object** to processing (e.g., direct marketing).
## 11.5 Core Ethical Issues in the Data Lifecycle
### 1. Privacy
> **Privacy** is the right to control access to facts about oneself and one's life. It is a **fundamental human right** linked to **autonomy, individuality, intimacy, and security**.

**Why it Matters Beyond Obvious Harm**: Even if data seems "harmless," violating privacy constitutes a **wrong** because it usurps an individual's control over their self-presentation and personal information. (Example: secret laptop surveillance with no embarrassing content is still a violation).
### 2. Consent
> **Valid Consent** must be: **Informed** (the subject understands the use), **Autonomous** (freely given, not coerced), and **Ongoing** (can be withdrawn).

**Challenges in Practice**:
* **Implied Consent**: Often not sufficient for non-obvious data uses.
* **Terms & Conditions**: Lengthy, complex documents are a poor mechanism for **informed** consent.
* **Context & Drift**: Consent given for one purpose (e.g., improving service) does not cover unrelated future uses (e.g., psychological experiments).
### 3. Anonymisation & Data Linkage
**Situation**: A primary method to protect privacy when using data.
**Challenge**: **Data linkage** (combining datasets) can **re-identify** individuals even from anonymised data.
* **Direct Identifiers**: Name, address, NHS number – must be removed.
* **Indirect Identifiers**: Postcode, age, rare disease – in combination, can identify individuals. Risk must be assessed and mitigated.
## 11.6 Case Studies in Ethical Failure
### Target's Pregnancy Prediction (2012)
* **What**: Data scientists analyzed shopping patterns to identify pregnant customers and send targeted coupons.
* **Ethical Issue**: Violation of **privacy** and lack of **meaningful consent**. Customers did not know their data was being used for this sensitive inference. It caused distress (e.g., revealing a teen's pregnancy to her father).
### Facebook Emotional Contagion Experiment (2014)
* **What**: Researchers manipulated news feeds of 689,000 users to study "emotional contagion."
* **Ethical Issues**:
    1.  **Lack of Informed Consent**: Burying permission in Terms of Service is inadequate. Users did not consent to **psychological manipulation**.
    2.  **Potential for Harm**: The study could have negatively impacted vulnerable users' mental health.
    3.  **Broader Societal Risk**: This capability for manipulation has been linked to influencing elections (e.g., Cambridge Analytica), threatening **democratic autonomy**.
### COMPAS Recidivism Algorithm
* **What**: An algorithm used in US courts to predict a defendant's likelihood of reoffending.
* **Ethical Issue**: **Bias**. The algorithm, trained on historically biased policing and sentencing data, unfairly labelled Black defendants as higher risk than white defendants with similar profiles.
* **Types of Bias Illustrated**:
    * **Historical Bias**: The training data reflected past societal injustices.
    * **Proxy Discrimination**: Even if 'race' was not a direct feature, the algorithm used correlated proxies (e.g., postcode, income).
    * **Lack of Transparency & Accountability**: The "black box" nature made it hard to diagnose, challenge, or assign responsibility for unfair outcomes.
## 11.7 The Problem of Bias in Data Science
**Bias** leads to **unfair treatment** of individuals or groups. It can be introduced at multiple stages:
1.  **Data Collection Bias**: Non-representative samples (e.g., health data mostly from white males).
2.  **Historical Bias**: Data reflects past prejudices and inequalities.
3.  **Algorithmic Bias**: The model's design or objective function creates unfair outcomes.
4.  **Interpretation Bias**: Analysts' own preconceptions affect how results are understood and used.

**Why it's a Profound Ethical Problem**: Automated systems can **amplify and institutionalize** human biases at scale, making them harder to detect and correct, while obscuring **accountability**.
## 11.8 Moral Responsibility of the Data Scientist
**Central Question**: Are you responsible only for the technical accuracy of your analysis, or also for its **social consequences**?

**Arguments for Extended Responsibility**:
* **Foreseeability**: Many harmful uses (discrimination, manipulation) are foreseeable outcomes of certain types of analysis.
* **Professional Duty**: As an expert, you have a **duty of care** to consider how your work will be deployed, similar to engineers or doctors.
* **The "Neutral Tool" Fallacy**: Algorithms encode the values and priorities of their creators; they are not neutral.

**Conclusion for Practice**: The ethical data scientist must proactively ask:
1.  **Consent & Purpose**: Has the subject consented to *this* use of their data?
2.  **Responsible Execution**: Can I achieve this aim without causing unfair harm or undermining the original consent?
If the answer to either is unclear or "no," you have an ethical obligation to **reconsider, mitigate risks, or refrain from the analysis**.