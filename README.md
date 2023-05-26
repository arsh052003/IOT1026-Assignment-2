<p align="center">
	<a href="https://github.com/GwGibson/IOT1026-Assignment-2/actions/workflows/ci.yml">
    <img src="https://github.com/GwGibson/IOT1026-Assignment-2/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/GwGibson/IOT1026-Assignment-2/actions/workflows/formatting.yml">
    <img src="https://github.com/GwGibson/IOT1026-Assignment-2/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/GwGibson/IOT1026-Assignment-2" > 
    <img src="https://codecov.io/gh/GwGibson/IOT1026-Assignment-2/branch/main/graph/badge.svg?token=JS0857X5JD"/>
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">		
    </a>
</p>

# IOT1026-Assignment-2

Write a description of the project here and don't forget to update the badges.

**Bonus:** Improve the state diagram in the instructions.md file to use treasure chests and make a pull request to receive a 1% bonus. If multiple students make a pull request, the request I incorporate into the assignment will receive a 2% bonus. Ensure your pull request does not incorporate any other changes.

[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
        
[![ci](https://github.com/arsh052003/IOT1026-Assignment-2/actions/workflows/ci.yml/badge.svg)](https://github.com/arsh052003/IOT1026-Assignment-2/actions/workflows/ci.yml)
[![formatting](https://github.com/arsh052003/IOT1026-Assignment-2/actions/workflows/formatting.yml/badge.svg)](https://github.com/arsh052003/IOT1026-Assignment-2/actions/workflows/formatting.yml)
    [![codecov](https://codecov.io/gh/arsh052003/IOT1026-Assignment-2/branch/main/graph/badge.svg?token=54RHNRLEMB)](https://codecov.io/gh/arsh052003/IOT1026-Assignment-2)
        
        
        
Project description:
        
Execute Manipulate method for changing state of the chest, which will call Open, Lock, Unloock or Close method based on user action.
The Open, Lock, Unlock and Close methods will change the state to chest only if it is possible according to the state Diagram flow
![image](https://github.com/arsh052003/IOT1026-Assignment-2/assets/122691385/a19824be-27d6-4032-b510-c7de73959848)
        
The tressure chest has three contructors,  
        1. default constructor will assign defined values to the material, quality and lock type
        2. second constructor accepts three paramater, which will update the material, quality and lock type to user provided input
        3. Third constructor acceps one paramater as State, which will change the state of the chest depending on user input when we initialize the class
        
