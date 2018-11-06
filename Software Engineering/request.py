import requests

class movieApi:
	apiKey = ""
	url = ""
	call = ""

	def __init__(self, key, Url):
		self.apiKey = key
		self.url = Url
		self.call = self.url + self.apiKey

	def queryMovie(self, title):
		response = requests.get(self.call+title)
		a = response.status_code
		t = response.text
		print(a)
		print(self.call+title)
		print(t)
		return t


#"http://www.omdbapi.com/?i=tt3896198&apikey=3db990c4"
api = movieApi("3db990c4&", "http://www.omdbapi.com/?apikey=")
api.queryMovie("t="+"Blade runner")
