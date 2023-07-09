## 1.3.1
+ Bumped AndroidX core support library to 1.8.0.

## 1.3.0
+ Added `SavePayload` support on the WebGL platform.
+ Added `SavePayload.RequestPermissions` static method to request gallery permissions ahead of time.
+ Added `SavePayload.album` field for inspecting the `album` that was specified when creating the payload.
+ Added `SavePayload.Supported` static field for checking whether the platform supports the payload.
+ Added `SavePayload.Dispose` method for explicitly disposing payload regardless of whether it was saved.
+ Added `SharePayload` support for sharing images with transparency.
+ Added `SharePayload` support for reporting the payload receiver chosen by the user.
+ Added `SharePayload.Supported` static field for checking whether the platform supports the payload.
+ Added `SharePayload.Dispose` method for explicitly disposing payload regardless of whether it was shared.
+ Added NatShare settings menu in project settings, under `NatML > NatShare`.
+ Added `Embed AndroidX` project setting for preventing duplicate errors when embedding AndroidX native library.
+ Fixed share payload task not completing when user canceled sharing action on Android.
+ Refactored top-level namespace from `NatSuite.Sharing` to `NatML.Sharing`.
+ Deprecated `SharePayload.Commit` method. Use `SharePayload.Share` method instead.
+ Deprecated `SavePayload.Commit` method. Use `SavePayload.Save` method instead.
+ Removed `ISharePayload` interface.
+ Removed experimental `PrintPayload`.
+ Updated NatShare license from MIT to Apache 2.0.
+ NatShare now requires iOS 14+.

## 1.2.6
+ NatShare is now thread-safe and can be used from any arbitrary thread.
+ Fixed `FLAG_IMMUTABLE` fatal exception when sharing on Android S (#125).
+ Fixed "Select Photos" option in photo library permission dialog causing app to hang on iOS (#119).

## 1.2.5
+ Migrated to Unity Package Manager.
+ Fixed iOS crash when sharing action was canceled by user (#110).

## 1.2.4
+ Added `ISharePayload.AddImage` overload which takes in a raw pixel buffer.
+ Fixed sharing not working on iOS 14.
+ Fixed `SavePayload` with album name crashing on Android Q+.
+ Fixed `DllNotFoundException` when using any sharing payloads in the Unity Editor.
+ Removed method chaining support from all payloads. Use multiple invocations instead.
+ NatShare now requires Android API level 24+.

## 1.2.3
+ Moved documentation [online](http://docs.natsuite.io/natshare).
+ Fixed compiler errors when building with IL2CPP backend on Android.
+ Fixed "No apps can perform this action" error when sharing text on Android.
+ Reduced time taken when adding images to payloads.
+ NatShare now requires iOS 11+.

## 1.2.2
+ Updated top-level namespace to `NatSuite.Sharing` for parity with other NatSuite API's.
+ Updated `ISharePayload` methods to support chaining, making code easier and more declarative.
+ Implemented `async` pattern for sharing callback using `ISharePayload.Commit` method, further simplifying sharing code.
+ Added boolean return type for `ISharePayload.Commit` showing whether the sharing operation was successfully completed.
+ Fixed UI constraints error when sharing on iPad with iOS 13.
+ Deprecated `ISharePayload.Dispose` method.

## 1.2.1
+ Fixed `SavePayload.AddMedia` not working properly on Android.
+ Fixed `SavePayload` failing to save the first time the user is asked for permissions on iOS.

## 1.2.0
+ Migrated to an object-oriented approach, where sharing payloads are created then committed. See README for more details.
+ Added support for printing on iOS with `PrintPayload`.
+ Added support for sharing multiple items at once.
+ Upgraded API to .NET 4.
+ NatShare now requires Android API level 22+.

## 1.1f3
+ Added support for saving to an album in the camera roll.
+ Added `copy` parameter to `SaveToCameraRoll`. When `false`, the media file will be moved to the camera roll instead of being copied.
+ Deprecated `message` parameter in `Share*` functions.
+ Refactored all `Share*` functions to overloads of one `NatShare.Share` function.

## 1.1f2
+ Added callbacks to the `NatShare.Share...` functions. You can use these to know when the user has completed the sharing activity.
+ Added better error logging on iOS.
+ Changed `NatShare.GetThumbnail` to return the thumbnail texture instead of take a callback.
+ Deprecated the WebGL backend since most functions were not supported.

## 1.1f1
+ Added `ShareText` function for sharing plain text.
+ Added `ShareMedia` function for sharing media files like videos, images, and so on.
+ Refactored `Share` function to `ShareImage`.
+ Correctly set duration of video file being saved to camera roll on Android.
+ Fix creation date on saved video being incorrect on Android.
+ Fix sharing not being available for Instagram and Twitter on iOS.
+ Fix videos not being copied to the top level of the device gallery on Android.

## 1.0f3
+ Images being shared or saved will not appear in a "NatShare" album.
+ Added null checking in all functions to prevent crashing.
+ Fixed hard crash when thumbnail cannot be retreived on iOS.

## 1.0f2
+ Added ability to share images and videos with message.
+ Fixed tearing and skew in generated thumbnails on iOS.

## 1.0f1
+ First release.