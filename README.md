
# @datacamp/react-native-survicate

This package provides React Native bindings for the Survicate Mobile SDK.

## Getting started

Install the native Survicate Mobile SDK in your project by following the official instructions.

Then add the NPM package:

`$ yarn add @datacamp/react-native-survicate`

### Mostly automatic installation

`$ react-native link @datacamp/react-native-survicate`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `@datacamp/react-native-survicate` and add `RNSurvicate.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNSurvicate.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNSurvicatePackage;` to the imports at the top of the file
  - Add `new RNSurvicatePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':@datacamp_react-native-survicate'
  	project(':@datacamp_react-native-survicate').projectDir = new File(rootProject.projectDir, 	'../node_modules/@datacamp/react-native-survicate/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      implementation project(':@datacamp_react-native-survicate')
  	```

## Usage

The package provides lightweight bindings around some of the common Survicate Mobile SDK API methods:

```javascript
import Survicate from '@datacamp/react-native-survicate'

// Log events
Survicate.invokeEvent("My Event")

// Log screen views
Survicate.enterScreen("My Screen")
Survicate.leaveScreen("My Screen")

// Set user traits
Survicate.setUserId("12345")
Survicate.setUserTrait("Eye Color", "Green")
```
  
