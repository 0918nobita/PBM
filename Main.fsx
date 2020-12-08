open System.IO

let () =
    use writer = new BinaryWriter(File.Open("out.ppm", FileMode.Create))
    writer.Write("P6\n100 100\n255\n"B)
    let bytes = Array.zeroCreate 30000
    let rnd = System.Random()
    rnd.NextBytes(bytes)
    writer.Write(bytes)
