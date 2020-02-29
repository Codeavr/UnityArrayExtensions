Array Extensions
===
## Why
This:
```c#
Array.ForEach(array, print);
```
Transforms into:
```c#
array.ForEach(print);
```


## Install

Find `Packages/manifest.json` in your project and edit it to look like this:
```json
{
  "dependencies": {
    "com.codeavr.array-extensions": "https://github.com/Codeavr/UnityArrayExtensions.git"
  }
}
```


### Requirements

* Unity any version
* Git

## License

* MIT
