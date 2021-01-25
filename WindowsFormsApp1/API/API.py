#!/usr/bin/env python
# encoding: utf-8

import json
import config
from flask import Flask, request
import azure.cognitiveservices.speech as speechsdk

STOP_AUTOMATIC = False
configVariables = {}

# Load App Configuration
with open("../Config/AppConfig","r") as configFile:
	for line in configFile:
		line = line.strip('\n')
		if len(line):
			values = line.split(' = ')
			configVariables[values[0][1:-1]] = values[1]

app = Flask(__name__)


def string_from_mic_improved(listen):
	speech_config = speechsdk.SpeechConfig(subscription=config.API_KEY, region="francecentral")
	speech_recognizer = speechsdk.SpeechRecognizer(speech_config=speech_config, language="fr-FR")
	if listen == False:
		print("\nEcoute passive...")
	result = speech_recognizer.recognize_once_async().get()
	if listen==True:
		print("Humain: ", result.text)
	return result.text


def voice_recognition(userClick=False, automatic=True):
	activate = True
	listen = True if userClick else False
	startWord = configVariables['USERNAME']
	stopWords = ["stop", "Stop", "t'ordonne de cesser l'écoute"]

	start_response = False
	response = []

	global STOP_AUTOMATIC

	if userClick:
		STOP_AUTOMATIC = True

	while activate:
		if STOP_AUTOMATIC and automatic:
			return "Automatic recognition stopped by the user"

		# If the user click then the passive listening is useless
		# so we set the text to the startWord to enter the new loop
		if not userClick:
			text = string_from_mic_improved(listen)
			print("Classic: ", text)
		else:
			text = startWord

		if startWord in text:
			listen = True
			if not automatic:
				text = ""

			if any(word in text for word in stopWords):
				activate = False
				listen = False

			if not userClick: response.append(text)
			while listen:
				text = string_from_mic_improved(listen)
				if any(word in text for word in stopWords):
					activate = False
					listen = False

				response.append(text)

	if userClick:
		STOP_AUTOMATIC = False

	response = '/'.join(response)

	for word in stopWords:
		response = response.replace(word, "")

	if STOP_AUTOMATIC:
		STOP_AUTOMATIC = False

	return response


@app.route('/')
def index():
	return "API is running"


@app.route('/getSpeechClicked', methods=['GET'])
def getSpeechClicked():
	return voice_recognition(userClick=True, automatic=False)


@app.route('/getSpeechAutomatic', methods=['GET'])
def getSpeech():
	return voice_recognition()

@app.route('/shutdown', methods=['GET'])
def shutdown():
	func = request.environ.get('werkzeug.server.shutdown')
	if func is None:
		raise RuntimeError('Not running with the Werkzeug Server')
	func()
	return "Closing the app"


app.run(debug=True)