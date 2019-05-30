## Table of Contents
* [General Info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Contributing](#contributing)
* [License](#license)

## General Info
This application allows searching a number from a given set of numbers following the binary search algorithm

>**Binary search algorithm** search a sorted array by repeatedly dividing the search interval in half. At the first time the search interval covers the whole array. If the value of the search key is less than the item in the middle of the search interval then the control goes to the left half. Otherwise the control goes to the right half. This process goes on and on until the value is found or the search interval is empty.

Let us search 50 in the following sorted array of numbers:

 #### 1 5 17 20 23 30 38 40 46 50 59 60 67 70 74
 #### 1 5 17 20 23 30 38 `40` 46 50 59 60 67 70 74&nbsp;&nbsp;&nbsp;mid=(0+14)/2=7; As 50>40, control goes to the right half
 #### ~~1 5 17 20 23 30 38 40~~ 46 50 59 `60` 67 70 74&nbsp;&nbsp;&nbsp;mid=(8+14)/2=11; As 50<60, control goes to the left half
 #### ~~1 5 17 20 23 30 38 40~~ 46 `50` 59 ~~60 67 70 74~~&nbsp;&nbsp;&nbsp;mid=(8+10)/2=9; As 50=50, 50 is found finally

## Technologies
This application is created with:
* Visual Studio 2013
* C# 
	
## Setup
To clone and run this repository you will need [Git](https://git-scm.com/) installed on your computer. From your command line:

```
# Clone this repository
$ git clone https://github.com/sumuongit/binary-search-algorithm.git
# Go into the repository
$ cd binary-search-algorithm
```

## Contributing
* Fork the repository
* Create a topic branch
* Implement your feature or bug fix
* Add, commit, and push your changes
* Submit a pull request

## License
[MIT License](https://github.com/sumuongit/binary-search-algorithm/blob/master/LICENSE)
