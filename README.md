# iotPlatform

## Tasks Done

- [x] Added `[FromHeader]` support for custom headers (e.g., `X-App-Version`)
- [x] Added const string `DeviceSharedSecretHeader` = "x-device-shared-secret" for reusability;
- [x] Implemented `FirmwareAttribute` for semantic version format validation using semver regex
- [x] Applied validation to request models and integrated with `[ReadingsController]`
- [x] Fixed Temperature condition for alerts validation service.