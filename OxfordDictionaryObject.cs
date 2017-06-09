using System;
using System.Collections.Generic;
using System.Linq;

/*
RetrieveEntry {
metadata(object, optional): Additional Information provided by OUP ,
results(Array[HeadwordEntry], optional): A list of entries and all the data related to them 
}
*/
public class RetrieveEntry
{
	public MetaData MetaData { get; set; }
	public List<HeadwordEntry> Results { get; set; }
}

public class MetaData
{
	public string Provider { get; set; }
}

/*
HeadwordEntry {
id(string): The identifier of a word ,
language(string): IANA language code ,
lexicalEntries(Array[lexicalEntry]): A grouping of various senses in a specific language, and a lexical category that relates to a word ,
pronunciations(PronunciationsList, optional),
type(string, optional): The json object type.Could be 'headword', 'inflection' or 'phrase' ,
word (string): A given written or spoken realisation of a an entry, lowercased.
}
*/
public class HeadwordEntry
{
	public string Id;
	public string Language;
	public List<LexicalEntry> LexicalEntries;
	public List<Pronunciation> Pronunciations;
	public string Type;
	public string Word;
}

/*
lexicalEntry {
derivativeOf(ArrayOfRelatedEntries, optional): Other words from which this one derives,
entries (Array[Entry], optional),
grammaticalFeatures (GrammaticalFeaturesList, optional),
language (string): IANA language code ,
lexicalCategory (string): A linguistic category of words (or more precisely lexical items), generally defined by the syntactic or morphological behaviour of the lexical item in question, such as noun or verb ,
notes (CategorizedTextList, optional),
pronunciations (PronunciationsList, optional),
text (string): A given written or spoken realisation of a an entry. ,
variantForms (VariantFormsList, optional): Various words that are used interchangeably depending on the context, e.g 'a' and 'an' 
}
*/
public class LexicalEntry
{
	public ArrayOfRelatedEntries DerivativeOf;
	public List<Entry> Entries;
	public List<GrammaticalFeature> GrammaticalFeatures;
	public string Language;
	public string LexicalCategory;
	public List<CategorizedText> Notes;
	public List<Pronunciation> Pronunciations;
	public string Text;
	public List<VariantForm> VariantForms;
}
/*
PronunciationsList[
audioFile (string, optional): The URL of the sound file ,
dialects (arrayofstrings, optional): A local or regional variation where the pronunciation occurs, e.g. 'British English' ,
phoneticNotation (string, optional): The alphabetic system used to display the phonetic spelling ,
phoneticSpelling (string, optional): Phonetic spelling is the representation of vocal sounds which express pronunciations of words. It is a system of spelling in which each letter represents invariably the same spoken sound ,
regions (arrayofstrings, optional): A particular area in which the pronunciation occurs, e.g. 'Great Britain' 
]
*/
public class Pronunciation
{
	public string AudioFile;
	public List<string> Dialects;
	public string PhoneticNotation;
	public string PhoneticSpelling;
	public List<string> Regions;
}

/*
Entry {
etymologies (arrayofstrings, optional): The origin of the word and the way in which its meaning has changed throughout history ,
grammaticalFeatures (GrammaticalFeaturesList, optional),
homographNumber (string, optional): Identifies the homograph grouping. The last two digits identify different entries of the same homograph. The first one/two digits identify the homograph number. ,
notes (CategorizedTextList, optional),
pronunciations (PronunciationsList, optional),
senses (Array[Sense], optional): Complete list of senses ,
variantForms (VariantFormsList, optional): Various words that are used interchangeably depending on the context, e.g 'a' and 'an' 
}
*/
public class Entry
{
	public List<string> etymologies;
	public List<GrammaticalFeature> GrammaticalFeatures;
	public string HomographNumber;
	public List<CategorizedText> Notes;
	public List<Pronunciation> Pronunciations;
	public List<Sense> Senses;
	public List<VariantForm> VariantForms;
}

/*
Sense {
crossReferenceMarkers (arrayofstrings, optional): A grouping of crossreference notes. ,
crossReferences (CrossReferencesList, optional),
definitions (arrayofstrings, optional): A list of statements of the exact meaning of a word ,
domains (arrayofstrings, optional): A subject, discipline, or branch of knowledge particular to the Sense ,
examples (ExamplesList, optional),
id (string, optional): The id of the sense that is required for the delete procedure ,
notes (CategorizedTextList, optional),
pronunciations (PronunciationsList, optional),
regions (arrayofstrings, optional): A particular area in which the Sense occurs, e.g. 'Great Britain' ,
registers (arrayofstrings, optional): A level of language usage, typically with respect to formality. e.g. 'offensive', 'informal' ,
subsenses (Array[Sense], optional): Ordered list of subsenses of a sense ,
translations (TranslationsList, optional),
variantForms (VariantFormsList, optional): Various words that are used interchangeably depending on the context, e.g 'duck' and 'duck boat' 
}
*/
public class Sense
{
	public List<string> CrossReferenceMarkers;
	public List<CrossReference> CrossReferences;
	public List<string> Definitions;
	public List<string> Domains;
	public List<Example> Examples;
	public string Id;
	public List<CategorizedText> Notes;
	public List<Pronunciation> Pronunciations;
	public List<string> Regions;
	public List<string> Registers;
	public List<Sense> Subsenses;
	public List<Translation> Translations;
	public List<VariantForm> VariantForms;
}

public class ArrayOfRelatedEntries
{
	public List<string> Domains;
	public string Id;
	public string Language;
	public List<string> Regions;
	public List<string> Registers;
	public string Text;
}

/*
GrammaticalFeaturesList[
text (string),
type (string)
]
*/
public class GrammaticalFeature
{
	public string Text;
	public string Type;
}

/*
CategorizedTextList[
id (string, optional): The identifier of the word ,
text (string): A note text ,
type (string): The descriptive category of the text 
]
*/
public class CategorizedText
{
	public string Id;
	public string Text;
	public string Type;
}

/*
VariantFormsList[
regions (arrayofstrings, optional): A particular area in which the variant form occurs, e.g. 'Great Britain' ,
text (string)
]
*/
public class VariantForm
{
	public List<string> Regions;
	public string Text;
}

/*
CrossReferencesList [
id (string): The word id of cooccurrence ,
text (string): The word of cooccurrence ,
type (string): The type of relation between the two words. Possible values are 'close match', 'related', 'see also', 'variant spelling', and 'abbreviation' in case of crossreferences, or 'pre', 'post' in case of collocates. 
]
*/
public class CrossReference
{
	public string Id;
	public string Text;
	public string Type;
}

/*
ExamplesList[
definitions(arrayofstrings, optional): A list of statements of the exact meaning of a word,
domains(arrayofstrings, optional): A subject, discipline, or branch of knowledge particular to the Sense,
notes(CategorizedTextList, optional),
regions(arrayofstrings, optional): A particular area in which the pronunciation occurs, e.g. 'Great Britain',
registers(arrayofstrings, optional): A level of language usage, typically with respect to formality.e.g. 'offensive', 'informal',
senseIds(arrayofstrings, optional): The list of sense identifiers related to the example.Provided in the sentences endpoint only. ,
text(string),
translations(TranslationsList, optional)
]
*/
public class Example
{
	public List<string> Definitions;
	public List<string> Domains;
	public List<CategorizedText> Notes;
	public List<string> Regions;
	public List<string> Registers;
	public List<string> SenseIds;
	public string Text;
	public List<Translation> Translations;
}

/*
TranslationsList[
domains(arrayofstrings, optional): A subject, discipline, or branch of knowledge particular to the translation,
grammaticalFeatures(GrammaticalFeaturesList, optional),
language(string): IANA language code specifying the language of the translation,
notes(CategorizedTextList, optional),
regions(arrayofstrings, optional): A particular area in which the translation occurs, e.g. 'Great Britain',
registers(arrayofstrings, optional): A level of language usage, typically with respect to formality.e.g. 'offensive', 'informal',
text(string)
]
*/
public class Translation
{
	public List<string> Domains;
	public List<GrammaticalFeature> GrammaticalFeatures;
	public string Language;
	public List<CategorizedText> Notes;
	public List<string> Regions;
	public List<string> Registers;
	public string Text;
}