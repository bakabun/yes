fn main() {
    let mut bufsize = 65536;    // modify the max buffer size
    let so = io::stdout();
    let mut h = so.lock();
    let mut bw = io::BufWriter::new(h);
    let mut args = env::args();
    args.next();
    let mut input = match args.next() {
        Some(s) => s,
        None => "y".to_string()
    };
    input.push('\n');
    let mut bufout = String::new();
    while bufsize > 0 {
        bufout.push_str(input.as_str());
        bufsize = bufsize - input.len();
    }
    loop {
        if let Err(_) =  write!(bw, "{}", bufout) {
            std::process::exit(0);
        };
    }
}