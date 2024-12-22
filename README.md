![Bug with a proto sign](header.jpg)

# Motivation
This repository was established for the purpose of investigating the potential of protobuf editor extensions. It is expected that the extension will be capable of detecting all errors within proto files.

# Supported syntax
The repository only covers syntax [proto3](https://protobuf.dev/programming-guides/proto3/) of protobuf.

# Structure
There are several samples with simple proto definitions. Each of these proto definitions has at least one error. I haeve grouped the samples by context:

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
