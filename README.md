# Vision Group Coding Challenge
Congratulations on your decision to apply for a position in the Gentex manufacturing machine vision group!

As part of the application process, we would like you to complete a coding challenge.
You have been provided with files that contain the definitions of several shapes, such as circles, ellipses, triangles, squares, and simple polygons.
In this exercise, you will programmatically read this file, calculate geometric properties, and save the calculated data to a new file.

## Directions
Your code should do the following:

- Read shape data from one of the provided files
    - More information on the available file formats is provided [below](#input)
- Calculate the area and perimeter of each shape
    - _Optionally, also calculate the X and Y coordinate of each shape’s centroid_
- Save a CSV file containing the requested geometric properties of each shape
    - More information on the output file format is provided [below](#output)

## Requirements
- Source code must be submitted via a GitHub repository link.
- Your program must be written in C# or VB.NET.
- You may not use 3rd-party libraries to calculate the requested geometric properties (area, perimeter, centroid)

## Tips
- Use object oriented programming practices
- You are encouraged to use 3rd-party libraries for any functionality _except when calculating the requested geometric properties_
- The [shoelace formula](https://en.wikipedia.org/wiki/Shoelace_formula) can be used to calculate the area of simple polygons
- This is not a closed book test: you are encouraged to use all available sources of information.
    (Do not include any proprietary code.)
- Unit testing may be used to verify code functionality
- Don’t hesitate to reach out to your hiring manager with questions
- An incomplete submission is acceptable: complete what your skill set allows
- _(Internal candidates only)_ Do not use any internally developed references in your solution

## File Formatting
### Input
You have been provided with two different files containing the same data in different formats.
You may choose between a JSON or comma-separated format.

> _Choose **ONE** of the provided files to read in your program._
> _You **DO NOT** need to parse both files: pick the one that is more convenient for you._

- All shapes have an integer ID
- Circles are specified by their center and radius
- Ellipses are specified by their center, the length of their two axes R1 and R2, and the orientation of R1 (radians)
- Squares and equilateral triangles are specified by their center, their side length, and the orientation of one of their sides (radians)
- Polygons are specified via a list of X,Y vertices

An example of the input file formats are provided [below](#file-examples)

### Output
Output the answers in a CSV format, providing a header line for the properties as named below:
- `Id`
- `Area`
- `Perimeter`
- `CentroidX` (optional)
- `CentroidY` (optional)

An example of the output file format is provided [below](#output-csv)

### File Examples
Examples of the input and output file formats are provided below.
All of the below examples were generated with the same data set containing two of each shape.

#### Output CSV
> You may either exclude the last two columns, or populate them with zeroes if you choose not to calculate the centroids.
```
Id,Area,Perimeter,CentroidX,CentroidY
1,5898.547204,307.208,363.122,408.663
2,8208.903609,362.412,103.017,279.442
3,1071.36719530946,120.852558618044,488.775,136.852
4,205.63182245055,172.880520795273,234.756,491.076
5,5241.16308482082,256.63670387175,338.591,157.296
6,8.35714225496608,10.2478752360099,424.026,495.951
7,3777.57406099637,280.206,349.971,263.142
8,151.614610179128,56.136,273.408,40.555
9,92802.3130010731,1264.17855076496,309.677699364237,237.888370259305
10,47840.3766543106,1007.79325769393,282.322058285915,302.902987984084
```

#### Input Comma-separated
```
1,Square,CenterX,363.122,CenterY,408.663,SideLength,76.802,Orientation,3.507
2,Square,CenterX,103.017,CenterY,279.442,SideLength,90.603,Orientation,2.778
3,Ellipse,CenterX,488.775,CenterY,136.852,R1,14.595,R2,23.366,Orientation,3.975
4,Ellipse,CenterX,234.756,CenterY,491.076,R1,1.518,R2,43.119,Orientation,6.254
5,Circle,CenterX,338.591,CenterY,157.296,Radius,40.845
6,Circle,CenterX,424.026,CenterY,495.951,Radius,1.631
7,Equilateral Triangle,CenterX,349.971,CenterY,263.142,SideLength,93.402,Orientation,4.32
8,Equilateral Triangle,CenterX,273.408,CenterY,40.555,SideLength,18.712,Orientation,2.848
9,Polygon,X0,136.726,Y0,453.549,X1,494.272,Y1,321.349,X2,478.728,Y2,252.565,X3,381.482,Y3,15.197,X4,228.604,Y4,73.413,X5,190.502,Y5,171.571,X6,136.726,Y6,453.549
10,Polygon,X0,97.457,Y0,439.096,X1,412.712,Y1,367.699,X2,429.11,Y2,339.875,X3,312.433,Y3,109.203,X4,97.457,Y4,439.096
```

#### Input JSON
```json
{
  "Squares": [
    {
      "Id": 1,
      "CenterX": 363.122,
      "CenterY": 408.663,
      "SideLength": 76.802,
      "Orientation": 3.507
    },
    {
      "Id": 2,
      "CenterX": 103.017,
      "CenterY": 279.442,
      "SideLength": 90.603,
      "Orientation": 2.778
    }
  ],
  "Ellipses": [
    {
      "Id": 3,
      "CenterX": 488.775,
      "CenterY": 136.852,
      "R1": 14.595,
      "R2": 23.366,
      "Orientation": 3.975
    },
    {
      "Id": 4,
      "CenterX": 234.756,
      "CenterY": 491.076,
      "R1": 1.518,
      "R2": 43.119,
      "Orientation": 6.254
    }
  ],
  "Circles": [
    {
      "Id": 5,
      "CenterX": 338.591,
      "CenterY": 157.296,
      "Radius": 40.845
    },
    {
      "Id": 6,
      "CenterX": 424.026,
      "CenterY": 495.951,
      "Radius": 1.631
    }
  ],
  "EquilateralTriangles": [
    {
      "Id": 7,
      "CenterX": 349.971,
      "CenterY": 263.142,
      "SideLength": 93.402,
      "Orientation": 4.32
    },
    {
      "Id": 8,
      "CenterX": 273.408,
      "CenterY": 40.555,
      "SideLength": 18.712,
      "Orientation": 2.848
    }
  ],
  "Polygons": [
    {
      "Id": 9,
      "XCoordinates": [
        136.726,
        494.272,
        478.728,
        381.482,
        228.604,
        190.502,
        136.726
      ],
      "YCoordinates": [
        453.549,
        321.349,
        252.565,
        15.197,
        73.413,
        171.571,
        453.549
      ]
    },
    {
      "Id": 10,
      "XCoordinates": [
        97.457,
        412.712,
        429.11,
        312.433,
        97.457
      ],
      "YCoordinates": [
        439.096,
        367.699,
        339.875,
        109.203,
        439.096
      ]
    }
  ]
}
```