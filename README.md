# CohonenColorRecognition

Version 1:

  1. loads a bmp image;
  
  2. generates a random Cohonen network;
  
  3. teaches network using loaded image.
  

Cohonen network searches (or isolate) similar data in the data array. Version 1 works with bmp images, so network isolate similar colours. 

Code based on this tutorial: [AI-Junkie] (http://www.ai-junkie.com/ann/som/som1.html), except using exponential decay function: version 1 use simple linear functions. 

*Quantity of iterations is hardcoded in CohonenSOM.Services -> NetworkParameters -> IterationsQuantity.*

*Better use with small images*

