﻿using System;
using System.Collections.Generic;

namespace ThinkAway.Net.Mail.POP3.Traverse
{
	///<summary>
	/// An abstract class that implements the MergeLeafAnswers method.<br/>
	/// The method simply returns the union of all answers from the leaves.
	///</summary>
	internal abstract class MultipleMessagePartFinder : AnswerMessageTraverser<List<MessagePart>>
	{
		/// <summary>
		/// Adds all the <paramref name="leafAnswers"/> in one big answer
		/// </summary>
		/// <param name="leafAnswers">The answers to merge</param>
		/// <returns>A list with has all the elements in the <paramref name="leafAnswers"/> lists</returns>
		/// <exception cref="ArgumentNullException">if <paramref name="leafAnswers"/> is <see langword="null"/></exception>
		protected override List<MessagePart> MergeLeafAnswers(List<List<MessagePart>> leafAnswers)
		{
			if(leafAnswers == null)
				throw new ArgumentNullException("leafAnswers");

			// We simply create a list with all the answer generated from the leaves
			List<MessagePart> mergedResults = new List<MessagePart>();

			foreach (List<MessagePart> leafAnswer in leafAnswers)
			{
				mergedResults.AddRange(leafAnswer);
			}

			return mergedResults;
		}
	}
}