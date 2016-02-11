package main

import "fmt"
import "time"

func main() {
    max := 10000000

    slice := make([]int, max)

    for i := 0; i < max; i++ {
      slice[i] = i
    }

    start := time.Now().UTC()

    sum := 0
    for i := 0; i < max; i++ {
        sum += slice[i]
    }
    end := time.Now().UTC()

    fmt.Println(end.Sub(start))
}
