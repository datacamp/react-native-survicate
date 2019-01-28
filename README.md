
# react-native-survicate

## Getting started

`$ npm install react-native-survicate --save`

### Mostly automatic installation

`$ react-native link react-native-survicate`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-survicate` and add `RNSurvicate.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNSurvicate.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNSurvicatePackage;` to the imports at the top of the file
  - Add `new RNSurvicatePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-survicate'
  	project(':react-native-survicate').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-survicate/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-survicate')
  	```

## Usage
```javascript
import RNSurvicate from 'react-native-survicate';

// TODO: What to do with the module?
RNSurvicate;
```
  
