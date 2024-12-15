# Motivation
This repository was created to explore protobuf editor extensions. The extension should be able to detect all errors in proto files.

# Supported syntax
The repository only covers syntax [proto3](https://protobuf.dev/programming-guides/proto3/) of protobuf.

# Structure
There are multiple samples that contain simple proto definitions. Each of these proto definitions has at least one error. The samples are grouped by the context:

| Sample | Context  |
|--------|----------|
| s0xx   | File     |
| s1xx   | Message  |
| s2xx   | Field    |
| s3xx   | Package  |
| s4xx   | Import   |
| s5xx   | Enum     |
| s6xx   | Oneof    |
| s7xx   | Repeated |

Oneof
- naming camelCase/PascalCase
- Fields do not restart with 1
- is this really an error?
message Example {
    oneof test_oneof1 {
        int32 field1 = 1;
    }
    oneof test_oneof2 {
        string field1 = 2; // Error: Duplicate field name
    }
}


