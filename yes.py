#!/usr/bin/python3
import sys
import os

BUF_MAX_SIZE = 65536

input_str = sys.argv[1] if len(sys.argv) > 1 else 'y'
count = BUF_MAX_SIZE // (len(input_str) + 1)
output = '\n'.join([input_str] * count)
byte_output = bytearray(output, 'ASCII')

try:
    while True:
        os.write(1, byte_output)
except:
    sys.exit(1)
