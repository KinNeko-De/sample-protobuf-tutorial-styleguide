# Motivation
This repository was created to explore protobuf editor extensions. The extension should be able to detect all errors in proto files.

# Structure
There are muliple samples that contains simple proto definitions. Each of this proto definition has at least one error. The samples are grouped by the context:

| Sample | Context |
|--------|---------|
| s0x    | Syntax  |
| s1x    | Message |
| s2x    | Field   |
| s3x    | Package |
| s4x    | Import  |
| s5x    | Enum    |
| s6x    | Oneof   |

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


