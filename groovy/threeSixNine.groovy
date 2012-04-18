(1..100).each {
    m = it =~ /[369]/
    println m ? '¦ ' * m.count : it
}