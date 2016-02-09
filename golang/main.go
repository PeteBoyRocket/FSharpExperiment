package main

import "fmt"
import "time"

func main() {
    start := time.Now().UTC()
    sum := 0
    for i := 0; i < 10000000; i++ {
        sum += i
    }
    end := time.Now().UTC()

    fmt.Println(end.Sub(start))
}
