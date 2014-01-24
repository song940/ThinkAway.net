/*
 * Copyright ?2005, Mathew Hall
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:
 *
 *    - Redistributions of source code must retain the above copyright notice, 
 *      this list of conditions and the following disclaimer.
 * 
 *    - Redistributions in binary form must reproduce the above copyright notice, 
 *      this list of conditions and the following disclaimer in the documentation 
 *      and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
 * IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
 * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
 * OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
 * OF SUCH DAMAGE.
 */


namespace ThinkAway.Controls.XPTable.Themes
{
	/// <summary>
	/// Represents the different states of a TextBox
	/// </summary>
	public enum TextBoxStates
	{
		/// <summary>
		/// The TextBox is in its normal state
		/// </summary>
		Normal = 1,
		
		/// <summary>
		/// The TextBox is highlighted
		/// </summary>
		Hot = 2,
		
		/// <summary>
		/// The TextBox is selected
		/// </summary>
		Selected = 3,
		
		/// <summary>
		/// The TextBox is disabled
		/// </summary>
		Disabled = 4,
		
		/// <summary>
		/// The TextBox has focus
		/// </summary>
		Focused = 5,
		
		/// <summary>
		/// The TextBox is readonly
		/// </summary>
		ReadOnly = 6
	}
}