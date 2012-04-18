#!/usr/bin/python
#-*- coding: utf-8 -*-

for c in range(1,100):
	if str(c)[-1] in '369':
		print '짝',
	else:
		print c,
