object Main {
	def main(args: Array[String]) {
		(1 to 100).map{ x => val c = x.toString().count("369".contains(_)); if (c > 0) "clap " * c else x }.foreach(println)
	}
}