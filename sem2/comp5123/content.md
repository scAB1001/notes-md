# Prompt 
You are an expert in the UK UG BSc, MSc Computer Science, Cloud Computing Systems field. I am currently taking this module and need assistance writing my lecture revision notes for my exam. Ensure keywords, terminology, language and concepts are always clear and bold. There should be brief, concise examples and explanations for every important concept --- multiple if complex. I want no unnecessary spacing and I want clear headers that fit with the module outline.
I will provide you with exam papers, content and exam structure.

### Prerequisites
- The stated prerequisite for this module requires students
	- To have some background in distributed systems and networking
	- To be able to write code independently
- This module does not teach
	- the concepts of programming
	- the skills to program in a programming language
	- OS (Linux) skills
- General distributed systems concepts, e.g.
	- Terminology
	- Middleware
	- Service Oriented Architectures
	- Web services
	- Networking aspects
### Programming, Technologies, Tools
- Programming languages (Python, Java …)
- OS (Linux)
- Software installation
- Source code editor, e.g. VS Code
- Simulation software
- Mininet
- Prometheus
- Grafana
- Virtualisation
- Docker
- Kubernetes, Minikube, Kubectl
- Knative
- Hadoop, Spark
- Other
### Course Outline - Themes
1. Distributed system models and enabling technologies
2. Cloud computing - architectures, services, models, use cases
3. Public and private clouds
4. Virtualization of clusters/data centres, containers and unikernels
5. Virtual Infrastructure Management, Disaggregated computing
6. Resource management and Kubernetes
7. Software-defined networking and Network Functions Virtualization
8. Cloud programming and software environments
9. Serverless architectures
10. Cloud middleware and configuration management
11. Big data. MapReduce and Hadoop
12. Energy Efficiency
13. Ubiquitous clouds, Internet of things, Edge Computing, Edge Intelligence
14. A Glimpse on 6G mobile networks softwarization
15. Clouds in the Exascale
#### Text books (Content used for this module)
- Cloud Computing for Science and Engineering. I. Foster and D.B. Gannon. MIT Press, 2017
- Cloud computing. S. Bhowmik, Cambridge University Press, 2017
- Distributed Systems - Principles and Paradigms. Tanenbaum A.S. and van Steen M., Prentice Hall, 3rd Edition, 2017
- Computer Networking: A Top-Down Approach. J. Kurose and K. Ross, 8th Edition, Pearson, 2021
### Exam details
- Open book - bring any notes*

## Example of previous exam notes written for another module
```markdown 
# Lecture 1: Introduction to Data Science 
## 1. Core Definition & Scope > **Data Science** is a multidisciplinary field using principles, algorithms, and processes to extract **nonobvious and useful patterns** from **large data sets**. It encompasses the full **data lifecycle**: capture, cleaning, analysis, modelling, and presentation. * **Machine Learning (ML)** is a subset focused on algorithmic pattern extraction. * **Data Mining** typically analyses structured data for discovery. * **Data Science** includes **unstructured data** (e.g., social media), **big-data technologies**, and **data ethics**. ## 2. Datafication > **Datafication** is the process of taking all aspects of life and turning them into **quantifiable data**. Once datafied, information can be repurposed into new forms of value. **Example**: A **fitness tracker** datafies sleep, movement, and heart rate. The resulting data allows a user to derive **actionable insights**, such as linking poor sleep quality to late-night screen time, which would be difficult to notice otherwise. ## 3. Key Skills of a Data Scientist * **Technical**: Computer Science, Mathematics, Statistics, Machine Learning. * **Domain Expertise**: Understanding the specific field (e.g., healthcare, film). * **Soft Skills**: Communication, Presentation, **Data Visualisation**. ## 4. Core Process & Workflow 1. **Data Collection & Preparation**: **Collecting, Curating, Cleaning**. The most time-consuming phase. 2. **Analysis & Modelling**: **Visualize, Analyze, Model (Machine Learning)**. 3. **Critical Questions Before Modelling**: * Does the **past represent the future**? (Assumption for predictive models). * What is the **goal** of the model? * How will it be **used**? * What data is **needed** vs. **available**? 
## 5. Example Applications * **IMDb**: Structured, crowdsourced data enabling questions on actor careers, film success factors (**correlation** between budget/ratings), and societal trends (e.g., age disparity between actors/actresses). * **Gapminder**: Uses **GDP per capita** (a **metric** for national wealth) to analyse relationships with health outcomes like life expectancy, demonstrating **exploratory data analysis**. 
## 6. Historical Context & Greater Data Science (GDS) * **50-Year Foundation**: Roots in statistics (Tukey, Cleveland) advocating for a broader **data analysis** science beyond theory. * **Lesser Data Science (LDS)**: Current, narrow commercial focus on **big-data** tools and scalability. * **Greater Data Science (GDS)**: Donoho's proposed rigorous framework with six divisions: 1. Data Exploration & Preparation. 2. Data Representation & Transformation. 3. Computing with Data. 4. Data Modelling (includes both **statistical inference** and **predictive modelling**). 5. Data Visualisation & Presentation. 6. **Science about Data Science**: Empirical study of data analysis methods themselves. * **Common Task Framework (CTF)**: Key driver of ML progress; uses public **benchmarks**, shared data, and objective scoring to compare algorithms. 
## 7. Core Objectives & Values * **Primary Goal**: Derive **actionable insights**, not just numbers. Requires asking the **right questions**. * **Statistical Reasoning Values**: Understanding the **application domain**, appreciating the **small** (details matter), quest for **significance**, hunger for **exploration**. * **Future Direction**: Evolution towards **evidence-based methodology** via **Science about Data Science**, using meta-analysis of computational research to improve methods. 

# Lecture 2: Data Understanding & Profiling 
## 2.1 What is Data? > A **datum** is a single measurement of something on a scale understandable to both recorder and reader. **Example**: Using the **Titanic dataset** (891 rows, 12 columns) to predict passenger survival based on personal characteristics (age, ticket class, gender). This is a **classification** task.
```