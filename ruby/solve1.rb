class String
  def get_369
    return self unless self =~ /[369]/

    result = ''
    list = self.split(//)
    list.each { |item| result << 'clap' if item =~ /[369]/ }
    return result
  end
end

(1..100).each { |n| puts n.to_s.get_369 } 